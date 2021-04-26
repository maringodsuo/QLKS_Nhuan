namespace QLKS
{
    partial class ThuePhong
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvKhachHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label34 = new System.Windows.Forms.Label();
            this.cbGioiTinhKH = new System.Windows.Forms.ComboBox();
            this.txtGhiChuKH = new System.Windows.Forms.TextBox();
            this.txtCMNDKH = new System.Windows.Forms.TextBox();
            this.txtQuocTichKh = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.labelgc = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtIDKH = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.txtEmailKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.btXacNhanThue = new System.Windows.Forms.Button();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayDI = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btLuuKH = new System.Windows.Forms.Button();
            this.btThemKH = new System.Windows.Forms.Button();
            this.errChiTiet = new System.Windows.Forms.ErrorProvider(this.components);
            this.label31 = new System.Windows.Forms.Label();
            this.txtTimKH = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvKhachHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 373);
            this.panel1.TabIndex = 0;
            // 
            // dtgvKhachHang
            // 
            this.dtgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.SDT,
            this.CMND,
            this.QuocTich,
            this.GhiChu});
            this.dtgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dtgvKhachHang.Name = "dtgvKhachHang";
            this.dtgvKhachHang.RowTemplate.Height = 24;
            this.dtgvKhachHang.Size = new System.Drawing.Size(1311, 373);
            this.dtgvKhachHang.TabIndex = 11;
            this.dtgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKhachHang_CellClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Ten";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tên Khách Hàng";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NgaySinh";
            this.dataGridViewTextBoxColumn10.HeaderText = "Ngày Sinh";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "GioiTinh";
            this.dataGridViewTextBoxColumn18.HeaderText = "Giới  Tính";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn19.HeaderText = "Email";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // QuocTich
            // 
            this.QuocTich.DataPropertyName = "QuocTich";
            this.QuocTich.HeaderText = "Quốc Tịch";
            this.QuocTich.Name = "QuocTich";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Thông Tin Khách Hàng";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(156, 132);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(169, 22);
            this.dtpNgaySinh.TabIndex = 47;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(52, 132);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(73, 17);
            this.label34.TabIndex = 46;
            this.label34.Text = "Ngày Sinh";
            // 
            // cbGioiTinhKH
            // 
            this.cbGioiTinhKH.FormattingEnabled = true;
            this.cbGioiTinhKH.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinhKH.Location = new System.Drawing.Point(156, 172);
            this.cbGioiTinhKH.Name = "cbGioiTinhKH";
            this.cbGioiTinhKH.Size = new System.Drawing.Size(169, 24);
            this.cbGioiTinhKH.TabIndex = 45;
            // 
            // txtGhiChuKH
            // 
            this.txtGhiChuKH.Location = new System.Drawing.Point(491, 185);
            this.txtGhiChuKH.Name = "txtGhiChuKH";
            this.txtGhiChuKH.Size = new System.Drawing.Size(169, 22);
            this.txtGhiChuKH.TabIndex = 41;
            // 
            // txtCMNDKH
            // 
            this.txtCMNDKH.Location = new System.Drawing.Point(491, 100);
            this.txtCMNDKH.Name = "txtCMNDKH";
            this.txtCMNDKH.Size = new System.Drawing.Size(169, 22);
            this.txtCMNDKH.TabIndex = 39;
            this.txtCMNDKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMNDKH_KeyPress);
            // 
            // txtQuocTichKh
            // 
            this.txtQuocTichKh.Location = new System.Drawing.Point(491, 146);
            this.txtQuocTichKh.Name = "txtQuocTichKh";
            this.txtQuocTichKh.Size = new System.Drawing.Size(169, 22);
            this.txtQuocTichKh.TabIndex = 40;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(387, 100);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 17);
            this.label20.TabIndex = 42;
            this.label20.Text = "CMND";
            // 
            // labelgc
            // 
            this.labelgc.AutoSize = true;
            this.labelgc.Location = new System.Drawing.Point(387, 188);
            this.labelgc.Name = "labelgc";
            this.labelgc.Size = new System.Drawing.Size(59, 17);
            this.labelgc.TabIndex = 43;
            this.labelgc.Text = "Ghi Chú";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(387, 146);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(73, 17);
            this.label35.TabIndex = 44;
            this.label35.Text = "Quốc Tịch";
            // 
            // txtIDKH
            // 
            this.txtIDKH.Location = new System.Drawing.Point(156, 55);
            this.txtIDKH.Name = "txtIDKH";
            this.txtIDKH.Size = new System.Drawing.Size(169, 22);
            this.txtIDKH.TabIndex = 30;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(52, 55);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 17);
            this.label25.TabIndex = 38;
            this.label25.Text = "ID";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(491, 55);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(169, 22);
            this.txtSDTKH.TabIndex = 33;
            this.txtSDTKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTKH_KeyPress);
            // 
            // txtEmailKH
            // 
            this.txtEmailKH.Location = new System.Drawing.Point(156, 213);
            this.txtEmailKH.Name = "txtEmailKH";
            this.txtEmailKH.Size = new System.Drawing.Size(169, 22);
            this.txtEmailKH.TabIndex = 32;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(156, 92);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(169, 22);
            this.txtTenKH.TabIndex = 31;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(52, 172);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 17);
            this.label26.TabIndex = 36;
            this.label26.Text = "Giới Tính";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(387, 58);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(36, 17);
            this.label27.TabIndex = 35;
            this.label27.Text = "SDT";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(52, 213);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(42, 17);
            this.label28.TabIndex = 37;
            this.label28.Text = "Email";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(52, 92);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(33, 17);
            this.label29.TabIndex = 34;
            this.label29.Text = "Tên";
            this.label29.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lbTenNhanVien);
            this.panel2.Controls.Add(this.btXacNhanThue);
            this.panel2.Controls.Add(this.txtTienCoc);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpNgayDI);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpNgayThue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(864, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 351);
            this.panel2.TabIndex = 1;
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTenNhanVien.Location = new System.Drawing.Point(267, 9);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(119, 20);
            this.lbTenNhanVien.TabIndex = 100;
            this.lbTenNhanVien.Text = "Tên Nhân Viên";
            // 
            // btXacNhanThue
            // 
            this.btXacNhanThue.BackColor = System.Drawing.Color.Lime;
            this.btXacNhanThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXacNhanThue.ForeColor = System.Drawing.Color.Black;
            this.btXacNhanThue.Location = new System.Drawing.Point(148, 221);
            this.btXacNhanThue.Name = "btXacNhanThue";
            this.btXacNhanThue.Size = new System.Drawing.Size(154, 66);
            this.btXacNhanThue.TabIndex = 56;
            this.btXacNhanThue.Text = "Xác Nhận Thuê";
            this.btXacNhanThue.UseVisualStyleBackColor = false;
            this.btXacNhanThue.Click += new System.EventHandler(this.btXacNhanThue_Click);
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(179, 156);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(169, 22);
            this.txtTienCoc.TabIndex = 54;
            this.txtTienCoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienCoc_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Tiền Cọc";
            // 
            // dtpNgayDI
            // 
            this.dtpNgayDI.Location = new System.Drawing.Point(179, 107);
            this.dtpNgayDI.Name = "dtpNgayDI";
            this.dtpNgayDI.Size = new System.Drawing.Size(207, 22);
            this.dtpNgayDI.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Ngày Đi";
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Location = new System.Drawing.Point(179, 62);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(207, 22);
            this.dtpNgayThue.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Ngày Thuê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(74, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Lịch trình";
            // 
            // btLuuKH
            // 
            this.btLuuKH.Image = global::QLKS.Properties.Resources.Save_icon;
            this.btLuuKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuuKH.Location = new System.Drawing.Point(721, 162);
            this.btLuuKH.Name = "btLuuKH";
            this.btLuuKH.Size = new System.Drawing.Size(109, 43);
            this.btLuuKH.TabIndex = 50;
            this.btLuuKH.Text = "Lưu";
            this.btLuuKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuuKH.UseVisualStyleBackColor = true;
            this.btLuuKH.Click += new System.EventHandler(this.btLuuKH_Click);
            // 
            // btThemKH
            // 
            this.btThemKH.Image = global::QLKS.Properties.Resources.add_1_icon;
            this.btThemKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemKH.Location = new System.Drawing.Point(721, 74);
            this.btThemKH.Name = "btThemKH";
            this.btThemKH.Size = new System.Drawing.Size(109, 55);
            this.btThemKH.TabIndex = 49;
            this.btThemKH.Text = "Thêm";
            this.btThemKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThemKH.UseVisualStyleBackColor = true;
            this.btThemKH.Click += new System.EventHandler(this.btThemKH_Click);
            // 
            // errChiTiet
            // 
            this.errChiTiet.ContainerControl = this;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(497, 290);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(352, 17);
            this.label31.TabIndex = 53;
            this.label31.Text = "Nhập bất cứ thứ gì liên quan đến đối tượng để tìm kiếm";
            // 
            // txtTimKH
            // 
            this.txtTimKH.Location = new System.Drawing.Point(125, 287);
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(335, 22);
            this.txtTimKH.TabIndex = 51;
            this.txtTimKH.TextChanged += new System.EventHandler(this.txtTimKH_TextChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(31, 287);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(72, 17);
            this.label32.TabIndex = 52;
            this.label32.Text = "Tìm kiếm: ";
            // 
            // ThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 724);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.txtTimKH);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.btLuuKH);
            this.Controls.Add(this.btThemKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.txtIDKH);
            this.Controls.Add(this.cbGioiTinhKH);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtGhiChuKH);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtCMNDKH);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtQuocTichKh);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.labelgc);
            this.Controls.Add(this.txtEmailKH);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.txtSDTKH);
            this.Controls.Add(this.label25);
            this.Name = "ThuePhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThuePhong";
            this.Load += new System.EventHandler(this.ThuePhong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox cbGioiTinhKH;
        private System.Windows.Forms.TextBox txtGhiChuKH;
        private System.Windows.Forms.TextBox txtCMNDKH;
        private System.Windows.Forms.TextBox txtQuocTichKh;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelgc;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtIDKH;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.TextBox txtEmailKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpNgayDI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btXacNhanThue;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuocTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Button btLuuKH;
        private System.Windows.Forms.Button btThemKH;
        private System.Windows.Forms.ErrorProvider errChiTiet;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtTimKH;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lbTenNhanVien;
    }
}