using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    internal class Data
    {
        public int UserID { get; set; }
        public string PasswordHash { get; set; }
        public string FullNmame { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public DateTime DateCreated { get; set; }

    }
    internal class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Quantity { get; set; }
        public int CategoryID { get; set; }
    }
    internal class Categories
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public override string ToString()
        {
            return CategoryName;
        }

    }
    internal class Students
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
