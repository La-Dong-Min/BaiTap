namespace Cau1_GUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbNoiSinh = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.cmBDonVi = new System.Windows.Forms.ComboBox();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.checkBoxGioiTinh = new System.Windows.Forms.CheckBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn vị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nơi sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh";
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(70, 7);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(167, 22);
            this.tbMa.TabIndex = 6;
            // 
            // tbNoiSinh
            // 
            this.tbNoiSinh.Location = new System.Drawing.Point(312, 36);
            this.tbNoiSinh.Name = "tbNoiSinh";
            this.tbNoiSinh.Size = new System.Drawing.Size(571, 22);
            this.tbNoiSinh.TabIndex = 7;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(312, 7);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(223, 22);
            this.tbHoTen.TabIndex = 8;
            // 
            // cmBDonVi
            // 
            this.cmBDonVi.FormattingEnabled = true;
            this.cmBDonVi.Location = new System.Drawing.Point(70, 36);
            this.cmBDonVi.Name = "cmBDonVi";
            this.cmBDonVi.Size = new System.Drawing.Size(167, 24);
            this.cmBDonVi.TabIndex = 9;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaySinh.Location = new System.Drawing.Point(641, 4);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(120, 22);
            this.dateNgaySinh.TabIndex = 10;
            // 
            // checkBoxGioiTinh
            // 
            this.checkBoxGioiTinh.AutoSize = true;
            this.checkBoxGioiTinh.Location = new System.Drawing.Point(768, 4);
            this.checkBoxGioiTinh.Name = "checkBoxGioiTinh";
            this.checkBoxGioiTinh.Size = new System.Drawing.Size(115, 21);
            this.checkBoxGioiTinh.TabIndex = 11;
            this.checkBoxGioiTinh.Text = "Giới tính Nam";
            this.checkBoxGioiTinh.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colHoTen,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colNoiSinh,
            this.colDonVi});
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 66);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(871, 347);
            this.dgvNhanVien.TabIndex = 12;
            // 
            // colMa
            // 
            this.colMa.DataPropertyName = "Ma";
            this.colMa.HeaderText = "Mã";
            this.colMa.Name = "colMa";
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 200;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Width = 150;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.Name = "colGioiTinh";
            // 
            // colNoiSinh
            // 
            this.colNoiSinh.DataPropertyName = "NoiSinh";
            this.colNoiSinh.HeaderText = "Nơi sinh";
            this.colNoiSinh.Name = "colNoiSinh";
            this.colNoiSinh.Width = 150;
            // 
            // colDonVi
            // 
            this.colDonVi.DataPropertyName = "DonVi";
            this.colDonVi.HeaderText = "Đơn vị";
            this.colDonVi.Name = "colDonVi";
            this.colDonVi.Width = 150;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(383, 442);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(120, 33);
            this.btThem.TabIndex = 13;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(509, 442);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(120, 33);
            this.btXoa.TabIndex = 14;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(635, 442);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(120, 33);
            this.btSua.TabIndex = 15;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(761, 442);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(120, 33);
            this.btThoat.TabIndex = 16;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 487);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.checkBoxGioiTinh);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.cmBDonVi);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.tbNoiSinh);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.TextBox tbNoiSinh;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.ComboBox cmBDonVi;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.CheckBox checkBoxGioiTinh;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonVi;
    }
}

