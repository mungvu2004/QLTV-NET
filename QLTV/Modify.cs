using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using OfficeOpenXml;


namespace QLTV
{
    internal class Modify
    {
        private string sql = @"Server=M-M;Initial Catalog=QLTV_1;Integrated Security=True;TrustServerCertificate=True";
        public static string CurrentUserRole { get; set; }
        public static int UserIDs { get; set; }
        public bool CheckLogin(string email, string password, string role, out string exMessage)
        {
            exMessage = null;   

            using(SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT UserID, PasswordHash, Role, Email FROM Users WHERE Email = @Email";
                    using(SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int UserID = reader.GetInt32(0);
                            string stored = reader.GetString(1);
                            string storedRode = reader.GetString(2);
                            string storedEmail = reader.GetString(3);
                            if (string.Equals(email, storedEmail, StringComparison.Ordinal))
                            {
                                if (BCrypt.Net.BCrypt.Verify(password, stored))
                                {
                                    if (storedRode.Equals(role, StringComparison.OrdinalIgnoreCase))
                                    {
                                        CurrentUserRole = storedRode;
                                        exMessage = "Bạn đã đăng nhập thành công!";
                                        UserIDs = UserID;
                                        return true;
                                    }
                                    else
                                    {
                                        exMessage = "Vai trò đăng nhập của bạn không đúng!";
                                    }

                                }
                                else
                                {
                                    exMessage = "Mật khẩu không chính xác!";
                                    return false;
                                }
                            }
                            else
                            {
                                exMessage = "Email không đúng!";
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    exMessage = ex.Message;
                    return false;
                }
            }
            return false;
            
        }
        public bool CheckEmail(string email, out string error)
        {
            error = null;
            using (SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users where Email = @email";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        int count = (int)cmd.ExecuteScalar();
                            if(count > 0)
                            {
                                return true;
                            }
                            else
                            {
                                error = "Email của bạn đã tồn tại";
                                return false;
                            }
                    }
                    
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return false;
                }
            }
           
        }
        public void Register(string email, string password, string fullname, out string e)
        {
            e = null;
            using(SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Email, PasswordHash, Fullname) VALUES (@email, @password, @fullname)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    e = ex.Message;
                }
            }
        }

        public List<Categories> Categrory()
        {
            List<Categories> theloai = new List<Categories>();
            using (SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "select CategoryID, CategoryName from Categories";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Categories category = new Categories
                                {
                                    CategoryID = reader.GetInt32(0),
                                    CategoryName = reader.GetString(1)
                                };
                                theloai.Add(category);
                            }
                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return theloai;
        }
        public List<Book> Books()
        {
            List<Book> books = new List<Book>();
            using (SqlConnection connection = new SqlConnection(sql))
            {
                
                try
                {
                    connection.Open();
                    string query = "SELECT BookID, Title, Author, YearPublished, Quantity, CategoryID FROM Books";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Book book = new Book
                                {
                                    BookID = reader.GetInt32(0),
                                    Title = reader.GetString(1),
                                    Author = reader.GetString(2),
                                    Year = reader.GetInt32(3),
                                    Quantity = reader.GetInt32(4),
                                    CategoryID = reader.GetInt32(5)
                                };
                                books.Add(book);
                            }
                        }
                    }
                    connection.Close();
                    Console.WriteLine("Đã đóng kết nối thành công.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine (ex.Message);
                    Console.WriteLine("Lỗi kết nối cơ sở dữ liệu: ");
                }
            }
            return books;
        }
        public void AddBook(string title, string author, int year, int quantity, int categoryID, out string notify) 
        {
            notify = null;
            using (SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Books (Title, Author, YearPublished, Quantity, CategoryID) VALUES (@Title, @Author, @YearPublished, @Quantity, @CategoryID);";
                    using(SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Author", author);
                        cmd.Parameters.AddWithValue("@YearPublished", year);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    Console.WriteLine("xác nhận thêm thành công!!");
                    
                }
                catch(SqlException ex)
                {
                    
                    Console.WriteLine("SQL Error: " + ex.Number);  // Mã lỗi SQL
                    Console.WriteLine("SQL Error Message: " + ex.Message);  // Thông báo chi tiết lỗi
                }
                catch(Exception ex)
                {
                    notify = ex.Message;
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void DeleteBook(int bookID)
        {
            using (SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Books where BookId = @bookID";
                    using( SqlCommand cmd = new SqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("@bookID", bookID);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public bool UpdateBook(int bookID, string title, string author, int year, int quantity, int categoryID)
        {
            using(SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Books SET Title = @title, Author = @author, YearPublished = @year, Quantity = @quantity, CategoryID = @categoryID WHERE BookId = @bookID";
                    using (SqlCommand cmd = new SqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.Parameters.AddWithValue("@year", year);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@categoryID", categoryID);
                        cmd.Parameters.AddWithValue("@bookID", bookID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
            
        }
        public DataTable SearchBook(string keyword)
        {
            DataTable dt = new DataTable();
            using(SqlConnection connection= new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Books WHERE Title LIKE @keyword OR Author LIKE @keyword";
                    using (SqlCommand cmd = new SqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
            return dt;
        }

        public void AddExcelBooks(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    if (worksheet == null)
                    {
                        throw new Exception("Sheet không tồn tại trong file Excel.");
                    }

                    var invalidDataMessages = new List<string>();

                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        string title = worksheet.Cells[row, 1].Text;
                        string author = worksheet.Cells[row, 2].Text;
                        bool isValidYear = int.TryParse(worksheet.Cells[row, 3].Text, out int year);
                        bool isValidQuantity = int.TryParse(worksheet.Cells[row, 4].Text, out int quantity);
                        bool isValidCategoryId = int.TryParse(worksheet.Cells[row, 5].Text, out int categoryId);

                        if (!isValidYear || !isValidQuantity || !isValidCategoryId || year <= 0 || quantity < 0 || categoryId <= 0)
                        {
                            invalidDataMessages.Add($"Dữ liệu không hợp lệ tại dòng {row}.");
                            continue;
                        }

                        string notify;
                        AddBook(title, author, year, quantity, categoryId, out notify);
                        if (!string.IsNullOrEmpty(notify))
                        {
                            invalidDataMessages.Add($"Lỗi thêm sách tại dòng {row}: {notify}");
                            Console.WriteLine(notify);
                        }
                    }

                    if (invalidDataMessages.Any())
                    {
                        MessageBox.Show(string.Join("\n", invalidDataMessages), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu từ file Excel đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        //-------------------------------------------------------------------------------------------------


        public bool CheckRole()
        {
            return CurrentUserRole.Equals("Admin", StringComparison.OrdinalIgnoreCase);
        }



        //--------------------------------------------------------------------------------------------------

        public List<Data> ShowUser()
        {
            List<Data> data = new List<Data>();
            using(SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "select * from Users";
                    using(SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Data user = new Data
                            {
                                UserID = reader.GetInt32(0),
                                PasswordHash = reader.GetString(1),
                                FullNmame = reader.GetString(2),
                                Email = reader.GetString(3),
                                Role = reader.GetString(4),
                                DateCreated = reader.GetDateTime(5)
                            };
                            data.Add(user);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); 
                }
            }
            return data;
        }

        public void DeleteAccount(int userID)
        {
            using(SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Users where UserID = @userID";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userID", userID);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public bool UpdateRole(int userID, string role)
        {
            using( SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Users SET Role = @role WHERE UserID = @userID";
                    using(SqlCommand cmd = new SqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@userID", userID);
                        return cmd.ExecuteNonQuery() > 0;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
        


        //---------------------------------------------------------------------------------------


        public DataTable GetStudent()
        {
            DataTable dt = new DataTable();
            using(SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Students";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine (ex.Message);
                    
                }
            }
            return dt;
        }


        public void InsertStudent(string id, string name, string address, string phone)
        {
            using(SqlConnection connection = new SqlConnection(sql))
            {
                connection.Open();
                string query = "INSERT INTO Students(StudentID, Name, Address, PhoneNumber) VALUES (@Id, @Name, @Address, @Phone)";
                try
                {
                    using(SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public bool EditStudent(string id, string name, string address, string phone)
        {
            using(SqlConnection conn = new SqlConnection(sql))
            {
                conn.Open();
                string query = "UPDATE Students SET Name = @Name, Address = @Address, PhoneNumber = @Phone WHERE StudentID = @ID";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public void DeleteStudent(string id)
        {
            using(SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Students WHERE StudentID = @ID";
                    using(SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
            }
        }


        public DataTable SearchStudent(string keyword)
        {
            DataTable dtStudent = new DataTable();
            using(SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Students WHERE Name LIKE @keyword OR StudentID LIKE @keyword";
                    using(SqlCommand cmd = new SqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dtStudent.Load(reader);
                        }
                        return dtStudent;
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    return new DataTable();
                }
            }
        }

        //-------------------------------------------------------------------------------------------

        public DataTable GetBorrow()
        {
            DataTable dtBorrow = new DataTable();
            using( SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT
                                        bb.BorrowID,
                                        s.StudentID,
                                        s.Name AS StudentName,
                                        b.Title AS BookTitle,
                                        u.FullName AS NameUser, 
                                        bb.BorrowDate,
                                        bb.ReturnDate,
                                        bb.Quantity,
                                        bb.Status
                                    FROM
                                        BorrowBooks bb
                                    INNER JOIN
                                        Students s ON bb.StudentID = s.StudentID
                                    INNER JOIN
                                        Books b ON bb.BookID = b.BookID
                                    INNER JOIN
                                        Users u ON  bb.UserID = u.UserID  ";
                    //WHERE 
                    //    (@Status IS NULL OR bb.Status = @Status OR bb.Status IS NULL)
                    using ( SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        //cmd.Parameters.AddWithValue("@Status",status);
                        using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dtBorrow);
                            return dtBorrow;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return new DataTable();
                }
            }
        }
        

        public bool UpdateBorrow(string StudentID, int bookID, DateTime returnDate, int quantity, out string message)
        {
            using( SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = $"INSERT INTO BorrowBooks (StudentID, BookID, UserID, Quantity, ReturnDate, Status) VALUES (@StudentID, @BookID, {UserIDs}, @Quantity, @ReturnDate, 'Borrowed')";
                    using(SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", StudentID);
                        cmd.Parameters.AddWithValue("@BookID", bookID);
                        
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Mượn sách thành công.";
                            return true;
                        }
                        else
                        {
                            message = "Mượn sách thất bại. Không có thay đổi nào được thực hiện.";
                            return false;
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    message = ex.Message;
                    return false;
                }
            }
        }

        public bool DeleteBorrow(int id, string status)
        {
            using(SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    if(status != "Lost")
                    {
                        string query = "UPDATE BorrowBooks SET Status = 'Lost' WHERE BorrowID = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@ID", id);
                            return cmd.ExecuteNonQuery() > 0;
                        }
                    }
                    else
                    {
                        string query = "DELETE FROM BorrowBooks WHERE BorrowID = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@ID", id);
                            return cmd.ExecuteNonQuery() > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public void EditBorrow(string StudentID, int bookID, int id, DateTime returnDate, int quantity, string status)
        {
            using(SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE BorrowBooks SET StudentID = @StudentID, BookID = @bookID, ReturnDate = @returnDate, Quantity = @quantity, Status = @Status WHERE BorrowID = @BorrowID";
                    using(SqlCommand cmd = new SqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", StudentID);
                        cmd.Parameters.AddWithValue("@bookID", bookID);
                        cmd.Parameters.AddWithValue("@returnDate", returnDate);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@BorrowID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        public DataTable SearchBorrow(string keyword, string check)
        {
            DataTable dataTable = new DataTable();
            using(SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT bb.BorrowID, s.StudentID, s.Name AS StudentName, b.Title AS BookTitle,u.FullName AS NameUser, bb.BorrowDate, bb.ReturnDate, bb.Quantity, bb.Status " +
                        "FROM BorrowBooks bb " +
                        "INNER JOIN Students s ON bb.StudentID = s.StudentID " +
                        "INNER JOIN Books b ON bb.BookID = b.BookID " +
                        "INNER JOIN Users u ON bb.UserID = u.UserID " +
                        "WHERE";
                    if(check.Equals("Student"))
                    {
                        query += "(s.Name LIKE @SearchTerm OR s.StudentID LIKE @SearchTerm);";
                    }
                    else if (check.Equals("Book"))
                    {
                        query += "(b.Title LIKE @SearchTerm );";
                    }
                    using( SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm" , "%" + keyword + "%");
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return new DataTable();
                }
            }
        }
        public DataTable DetailBorrow(string id)
        {
            DataTable dataTable = new DataTable();
            using( SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT b.BorrowID, s.StudentID, s.Name AS StudentName, k.Title AS BookTitle, b.Quantity, b.Status FROM BorrowBooks b JOIN Students s ON b.StudentID = s.StudentID JOIN Books k ON b.BookID = k.BookID WHERE b.StudentID = @StudentID;";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", id);
                        using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                            
                            if (!dataTable.Columns.Contains("BorrowID")) 
                            { 
                                throw new Exception("Column 'BorrowID' không tồn tại trong DataTable."); 
                            }
                            return dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return new DataTable();
                }
            }
        }

        //-------------------------------------------------------

        public DataTable Detailbook(int bookID)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "select b.Title, b.Author, bd.Detail from BookDetails bd inner join Books b ON bd.BookID = b.BookID where bd.BookID = @BookID";
                    using(SqlCommand cmd = new SqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookID);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                        return dataTable;
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return new DataTable();
                }
            }
        }

        //------------------------------------------------------------------

        public DataTable GetDate(int year, int month)
        {
            DataTable dataTable = new DataTable(); 
            using(SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = @"
                SELECT 
                    CONVERT(DATE, BorrowDate) AS NgayMuon,
                    SUM(Quantity) AS TongSoLuong
                FROM BorrowBooks WHERE YEAR(BorrowDate) = @Year AND MONTH(BorrowDate) = @Month
                GROUP BY CONVERT(DATE, BorrowDate)";
                    using(SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Year", year);
                        cmd.Parameters.AddWithValue("@Month", month);
                        using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                        return dataTable;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return new DataTable();
                }
            }
        }

        public DataTable GetMounth ()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string Query = @"
                SELECT 
                    FORMAT(BorrowDate, 'yyyy-MM') AS Thang,
                    SUM(Quantity) AS TongSoLuong
                FROM BorrowBooks
                GROUP BY FORMAT(BorrowDate, 'yyyy-MM')
                ORDER BY Thang;
            ";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                        return dataTable;
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                    return new DataTable();
                }
            }

        }

        public bool CheckDetail(int ID)
        {
            using (SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "select count(*) from where BookID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);
                        int Check = (int)cmd.ExecuteScalar();
                        if (Check > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        
        }
        public bool AddDetail(int ID, string detail)
        {
            using (SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string query = "insert into BookDetails(BookID, Detail) values(@BookID, @Detail) ";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@BookID", ID);
                        cmd.Parameters.AddWithValue("@Detail", detail);
                        return cmd.ExecuteNonQuery() > 0;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
        public bool AddCate(string tenTL, out string mess)
        {
            using(SqlConnection connection = new SqlConnection(sql))
            {
                try
                {
                    connection.Open();
                    string check = "SELECT COUNT(1) FROM Categories WHERE CategoryName = @CategoryName";
                    string insert = "INSERT INTO Categories (CategoryName) VALUES (@CategoryName)";
                    using(SqlCommand cmd = new SqlCommand(check, connection))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", tenTL);
                        int count = (int)cmd.ExecuteScalar();
                        if(count > 0)
                        {
                            mess = "Đã có thể loại sách này !!!";
                            return false;
                        }
                        else
                        {
                            using(SqlCommand command = new SqlCommand(insert, connection))
                            {
                                command.Parameters.AddWithValue("@CategoryName", tenTL);
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    mess = "Thể loại sách đã được thêm thành công.";
                                    return true;
                                }
                                else
                                {
                                    mess = "Thêm thể loại sách không thành công.";
                                    return false;
                                }
                            }
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    mess = ex.Message;
                    return false;
                }
            }
        }
    }
}

