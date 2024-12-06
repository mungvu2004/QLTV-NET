namespace QLTV
{
    partial class AddDetail
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
            this.cdbook = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMota = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCN = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // cdbook
            // 
            this.cdbook.BackColor = System.Drawing.Color.Transparent;
            this.cdbook.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cdbook.DropDownHeight = 70;
            this.cdbook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdbook.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cdbook.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cdbook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cdbook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cdbook.IntegralHeight = false;
            this.cdbook.ItemHeight = 30;
            this.cdbook.Location = new System.Drawing.Point(164, 104);
            this.cdbook.Name = "cdbook";
            this.cdbook.Size = new System.Drawing.Size(378, 36);
            this.cdbook.TabIndex = 3;
            // 
            // txtMota
            // 
            this.txtMota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMota.DefaultText = "";
            this.txtMota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMota.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMota.Location = new System.Drawing.Point(164, 250);
            this.txtMota.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMota.Name = "txtMota";
            this.txtMota.PasswordChar = '\0';
            this.txtMota.PlaceholderText = "";
            this.txtMota.SelectedText = "";
            this.txtMota.Size = new System.Drawing.Size(675, 267);
            this.txtMota.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sách";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập mô tả";
            // 
            // btnCN
            // 
            this.btnCN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCN.ForeColor = System.Drawing.Color.White;
            this.btnCN.Location = new System.Drawing.Point(630, 541);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(180, 45);
            this.btnCN.TabIndex = 0;
            this.btnCN.Text = "CẬP NHẬP";
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // AddDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 607);
            this.Controls.Add(this.btnCN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.cdbook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDetail";
            this.Load += new System.EventHandler(this.AddDetail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cdbook;
        private Guna.UI2.WinForms.Guna2TextBox txtMota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCN;
    }
}