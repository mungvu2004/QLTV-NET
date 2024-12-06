namespace QLTV
{
    partial class Detailbook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvdetail = new System.Windows.Forms.DataGridView();
            this.lbttct = new System.Windows.Forms.Label();
            this.lbtg = new System.Windows.Forms.Label();
            this.lbnamebook = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1025, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvdetail);
            this.panel2.Controls.Add(this.lbttct);
            this.panel2.Controls.Add(this.lbtg);
            this.panel2.Controls.Add(this.lbnamebook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 491);
            this.panel2.TabIndex = 1;
            // 
            // dgvdetail
            // 
            this.dgvdetail.AllowUserToAddRows = false;
            this.dgvdetail.AllowUserToResizeColumns = false;
            this.dgvdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdetail.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdetail.Location = new System.Drawing.Point(0, 320);
            this.dgvdetail.Name = "dgvdetail";
            this.dgvdetail.RowHeadersVisible = false;
            this.dgvdetail.RowHeadersWidth = 82;
            this.dgvdetail.RowTemplate.Height = 33;
            this.dgvdetail.Size = new System.Drawing.Size(1025, 171);
            this.dgvdetail.TabIndex = 3;
            this.dgvdetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetail_CellContentClick);
            // 
            // lbttct
            // 
            this.lbttct.Location = new System.Drawing.Point(127, 184);
            this.lbttct.Name = "lbttct";
            this.lbttct.Size = new System.Drawing.Size(783, 112);
            this.lbttct.TabIndex = 2;
            this.lbttct.Text = "Thông tin chi tiết : ";
            // 
            // lbtg
            // 
            this.lbtg.AutoSize = true;
            this.lbtg.Location = new System.Drawing.Point(127, 126);
            this.lbtg.Name = "lbtg";
            this.lbtg.Size = new System.Drawing.Size(101, 25);
            this.lbtg.TabIndex = 1;
            this.lbtg.Text = "Tác giả : ";
            // 
            // lbnamebook
            // 
            this.lbnamebook.AutoSize = true;
            this.lbnamebook.Location = new System.Drawing.Point(127, 49);
            this.lbnamebook.Name = "lbnamebook";
            this.lbnamebook.Size = new System.Drawing.Size(119, 25);
            this.lbnamebook.TabIndex = 0;
            this.lbnamebook.Text = "Tên sách : ";
            // 
            // Detailbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1025, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Detailbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detailbook";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbttct;
        private System.Windows.Forms.Label lbtg;
        private System.Windows.Forms.Label lbnamebook;
        private System.Windows.Forms.DataGridView dgvdetail;
    }
}