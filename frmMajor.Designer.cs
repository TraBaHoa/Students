namespace Lab05_GUI
{
    partial class frmMajor
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
            this.dgvDKCN = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbDKKhoa = new System.Windows.Forms.ComboBox();
            this.cbbDKCNganh = new System.Windows.Forms.ComboBox();
            this.btnDK = new System.Windows.Forms.Button();
            this.chon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDKCN)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDKCN
            // 
            this.dgvDKCN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDKCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDKCN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chon,
            this.MSSV,
            this.HoTen,
            this.Khoa,
            this.DTB});
            this.dgvDKCN.Location = new System.Drawing.Point(65, 150);
            this.dgvDKCN.Name = "dgvDKCN";
            this.dgvDKCN.Size = new System.Drawing.Size(676, 244);
            this.dgvDKCN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khoa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chuyên Ngành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đăng Ký Chuyên Ngành";
            // 
            // cbbDKKhoa
            // 
            this.cbbDKKhoa.FormattingEnabled = true;
            this.cbbDKKhoa.Location = new System.Drawing.Point(302, 77);
            this.cbbDKKhoa.Name = "cbbDKKhoa";
            this.cbbDKKhoa.Size = new System.Drawing.Size(264, 21);
            this.cbbDKKhoa.TabIndex = 3;
            this.cbbDKKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbDKKhoa_SelectedIndexChanged);
            // 
            // cbbDKCNganh
            // 
            this.cbbDKCNganh.FormattingEnabled = true;
            this.cbbDKCNganh.Location = new System.Drawing.Point(304, 111);
            this.cbbDKCNganh.Name = "cbbDKCNganh";
            this.cbbDKCNganh.Size = new System.Drawing.Size(264, 21);
            this.cbbDKCNganh.TabIndex = 3;
            this.cbbDKCNganh.SelectedIndexChanged += new System.EventHandler(this.cbbDKCNganh_SelectedIndexChanged);
            // 
            // btnDK
            // 
            this.btnDK.Location = new System.Drawing.Point(665, 108);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(75, 23);
            this.btnDK.TabIndex = 4;
            this.btnDK.Text = "Đăng Ký";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // chon
            // 
            this.chon.HeaderText = "chon";
            this.chon.Name = "chon";
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.Name = "HoTen";
            // 
            // Khoa
            // 
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.Name = "Khoa";
            // 
            // DTB
            // 
            this.DTB.HeaderText = "DTB";
            this.DTB.Name = "DTB";
            // 
            // frmMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDK);
            this.Controls.Add(this.cbbDKCNganh);
            this.Controls.Add(this.cbbDKKhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDKCN);
            this.Name = "frmMajor";
            this.Text = "frmMajor";
            this.Load += new System.EventHandler(this.frmMajor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDKCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDKCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbDKKhoa;
        private System.Windows.Forms.ComboBox cbbDKCNganh;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
    }
}