namespace QLTV
{
    partial class Borrow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.dtpReturn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnBook = new System.Windows.Forms.RadioButton();
            this.rbtnSv = new System.Windows.Forms.RadioButton();
            this.txtCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXemCT = new Guna.UI2.WinForms.Guna2Button();
            this.btnXóa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThêm = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2442, 150);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu mượn trả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.cbBook);
            this.groupBox1.Controls.Add(this.cbStudent);
            this.groupBox1.Controls.Add(this.dtpReturn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXemCT);
            this.groupBox1.Controls.Add(this.btnXóa);
            this.groupBox1.Controls.Add(this.btnThêm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2442, 505);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStatus.DropDownHeight = 100;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.Color.Silver;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.IntegralHeight = false;
            this.cbStatus.Location = new System.Drawing.Point(1056, 122);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(350, 33);
            this.cbStatus.TabIndex = 17;
            this.cbStatus.Leave += new System.EventHandler(this.cbStatus_Leave);
            // 
            // cbBook
            // 
            this.cbBook.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBook.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBook.DropDownHeight = 100;
            this.cbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBook.ForeColor = System.Drawing.Color.Silver;
            this.cbBook.FormattingEnabled = true;
            this.cbBook.IntegralHeight = false;
            this.cbBook.Location = new System.Drawing.Point(390, 244);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(361, 33);
            this.cbBook.TabIndex = 16;
            // 
            // cbStudent
            // 
            this.cbStudent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStudent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStudent.DropDownHeight = 100;
            this.cbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStudent.ForeColor = System.Drawing.Color.Silver;
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.IntegralHeight = false;
            this.cbStudent.Location = new System.Drawing.Point(390, 120);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(361, 33);
            this.cbStudent.TabIndex = 3;
            // 
            // dtpReturn
            // 
            this.dtpReturn.Checked = true;
            this.dtpReturn.CustomFormat = "dd/MM/yyyy";
            this.dtpReturn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturn.Location = new System.Drawing.Point(1056, 190);
            this.dtpReturn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpReturn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(350, 55);
            this.dtpReturn.TabIndex = 15;
            this.dtpReturn.Value = new System.DateTime(2024, 11, 26, 15, 22, 10, 803);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnBook);
            this.groupBox2.Controls.Add(this.rbtnSv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(90, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 150);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm theo";
            // 
            // rbtnBook
            // 
            this.rbtnBook.AutoSize = true;
            this.rbtnBook.Location = new System.Drawing.Point(67, 98);
            this.rbtnBook.Name = "rbtnBook";
            this.rbtnBook.Size = new System.Drawing.Size(107, 35);
            this.rbtnBook.TabIndex = 1;
            this.rbtnBook.Text = "Sách";
            this.rbtnBook.UseVisualStyleBackColor = true;
            // 
            // rbtnSv
            // 
            this.rbtnSv.AutoSize = true;
            this.rbtnSv.Checked = true;
            this.rbtnSv.Location = new System.Drawing.Point(67, 47);
            this.rbtnSv.Name = "rbtnSv";
            this.rbtnSv.Size = new System.Drawing.Size(156, 35);
            this.rbtnSv.TabIndex = 0;
            this.rbtnSv.TabStop = true;
            this.rbtnSv.Text = "Sinh viên";
            this.rbtnSv.UseVisualStyleBackColor = true;
            // 
            // txtCount
            // 
            this.txtCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCount.DefaultText = "";
            this.txtCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCount.Location = new System.Drawing.Point(1056, 297);
            this.txtCount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCount.Name = "txtCount";
            this.txtCount.PasswordChar = '\0';
            this.txtCount.PlaceholderText = "";
            this.txtCount.SelectedText = "";
            this.txtCount.Size = new System.Drawing.Size(350, 49);
            this.txtCount.TabIndex = 13;
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(936, 412);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(621, 41);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(664, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 42);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tìm kiếm:";
            // 
            // btnSua
            // 
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(1792, 297);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 45);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "SỬA";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXemCT
            // 
            this.btnXemCT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXemCT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXemCT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemCT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemCT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXemCT.ForeColor = System.Drawing.Color.White;
            this.btnXemCT.Location = new System.Drawing.Point(1792, 408);
            this.btnXemCT.Name = "btnXemCT";
            this.btnXemCT.Size = new System.Drawing.Size(180, 45);
            this.btnXemCT.TabIndex = 9;
            this.btnXemCT.Text = "CHI TIẾT";
            this.btnXemCT.Click += new System.EventHandler(this.btnXemCT_Click);
            // 
            // btnXóa
            // 
            this.btnXóa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXóa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXóa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXóa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXóa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXóa.ForeColor = System.Drawing.Color.White;
            this.btnXóa.Location = new System.Drawing.Point(1792, 189);
            this.btnXóa.Name = "btnXóa";
            this.btnXóa.Size = new System.Drawing.Size(180, 45);
            this.btnXóa.TabIndex = 8;
            this.btnXóa.Text = "XÓA";
            this.btnXóa.Click += new System.EventHandler(this.btnXóa_Click);
            // 
            // btnThêm
            // 
            this.btnThêm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThêm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThêm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThêm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThêm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThêm.ForeColor = System.Drawing.Color.White;
            this.btnThêm.Location = new System.Drawing.Point(1792, 88);
            this.btnThêm.Name = "btnThêm";
            this.btnThêm.Size = new System.Drawing.Size(180, 45);
            this.btnThêm.TabIndex = 7;
            this.btnThêm.Text = "THÊM";
            this.btnThêm.Click += new System.EventHandler(this.btnThêm_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 93);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sách";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 84);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.AllowUserToResizeColumns = false;
            this.dgvBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrow.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrow.Location = new System.Drawing.Point(0, 655);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrow.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBorrow.RowHeadersVisible = false;
            this.dgvBorrow.RowHeadersWidth = 82;
            this.dgvBorrow.RowTemplate.Height = 33;
            this.dgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrow.Size = new System.Drawing.Size(2442, 629);
            this.dgvBorrow.TabIndex = 2;
            this.dgvBorrow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellClick);
            this.dgvBorrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellContentClick);
            this.dgvBorrow.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvBorrow_DataBindingComplete);
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2442, 1284);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrow";
            this.Text = "Borrow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Borrow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXemCT;
        private Guna.UI2.WinForms.Guna2Button btnXóa;
        private Guna.UI2.WinForms.Guna2Button btnThêm;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnBook;
        private System.Windows.Forms.RadioButton rbtnSv;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpReturn;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.ComboBox cbStudent;
    }
}