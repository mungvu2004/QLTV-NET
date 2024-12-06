namespace QLTV
{
    partial class AddCate
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
            this.txtCate = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCate = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCate
            // 
            this.txtCate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCate.DefaultText = "";
            this.txtCate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCate.Location = new System.Drawing.Point(79, 139);
            this.txtCate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCate.Name = "txtCate";
            this.txtCate.PasswordChar = '\0';
            this.txtCate.PlaceholderText = "";
            this.txtCate.SelectedText = "";
            this.txtCate.Size = new System.Drawing.Size(654, 77);
            this.txtCate.TabIndex = 0;
            // 
            // btnCate
            // 
            this.btnCate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCate.ForeColor = System.Drawing.Color.White;
            this.btnCate.Location = new System.Drawing.Point(434, 334);
            this.btnCate.Name = "btnCate";
            this.btnCate.Size = new System.Drawing.Size(180, 45);
            this.btnCate.TabIndex = 1;
            this.btnCate.Text = "CẬP NHẬP";
            this.btnCate.Click += new System.EventHandler(this.btnCate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập thể loại sách muốn thêm:";
            // 
            // AddCate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCate);
            this.Controls.Add(this.txtCate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtCate;
        private Guna.UI2.WinForms.Guna2Button btnCate;
        private System.Windows.Forms.Label label1;
    }
}