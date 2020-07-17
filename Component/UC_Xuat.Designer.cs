namespace Project.Component
{
    partial class UC_Xuat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl_DanhSachXuatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.radioButton_TimTheoTenKhachHang = new System.Windows.Forms.RadioButton();
            this.radioButton_TimTheoTenNhanVien = new System.Windows.Forms.RadioButton();
            this.radioButton_TimTheoMPX = new System.Windows.Forms.RadioButton();
            this.txt_TimTheoTenKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.txt_TimTheoTenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txt_TimTheoMPX = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DanhSachXuatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoTenKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoTenNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoMPX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_DanhSachXuatHang
            // 
            this.gridControl_DanhSachXuatHang.Location = new System.Drawing.Point(3, 162);
            this.gridControl_DanhSachXuatHang.MainView = this.gridView1;
            this.gridControl_DanhSachXuatHang.Name = "gridControl_DanhSachXuatHang";
            this.gridControl_DanhSachXuatHang.Size = new System.Drawing.Size(854, 285);
            this.gridControl_DanhSachXuatHang.TabIndex = 12;
            this.gridControl_DanhSachXuatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl_DanhSachXuatHang;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.radioButton_TimTheoTenKhachHang);
            this.groupControl2.Controls.Add(this.radioButton_TimTheoTenNhanVien);
            this.groupControl2.Controls.Add(this.radioButton_TimTheoMPX);
            this.groupControl2.Controls.Add(this.txt_TimTheoTenKhachHang);
            this.groupControl2.Controls.Add(this.txt_TimTheoTenNhanVien);
            this.groupControl2.Controls.Add(this.txt_TimTheoMPX);
            this.groupControl2.Location = new System.Drawing.Point(3, 10);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(426, 146);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "Tìm Kiếm";
            // 
            // radioButton_TimTheoTenKhachHang
            // 
            this.radioButton_TimTheoTenKhachHang.AutoSize = true;
            this.radioButton_TimTheoTenKhachHang.Location = new System.Drawing.Point(17, 110);
            this.radioButton_TimTheoTenKhachHang.Name = "radioButton_TimTheoTenKhachHang";
            this.radioButton_TimTheoTenKhachHang.Size = new System.Drawing.Size(133, 17);
            this.radioButton_TimTheoTenKhachHang.TabIndex = 2;
            this.radioButton_TimTheoTenKhachHang.TabStop = true;
            this.radioButton_TimTheoTenKhachHang.Text = "Tìm Theo Khách Hàng";
            this.radioButton_TimTheoTenKhachHang.UseVisualStyleBackColor = true;
            // 
            // radioButton_TimTheoTenNhanVien
            // 
            this.radioButton_TimTheoTenNhanVien.AutoSize = true;
            this.radioButton_TimTheoTenNhanVien.Location = new System.Drawing.Point(17, 71);
            this.radioButton_TimTheoTenNhanVien.Name = "radioButton_TimTheoTenNhanVien";
            this.radioButton_TimTheoTenNhanVien.Size = new System.Drawing.Size(145, 17);
            this.radioButton_TimTheoTenNhanVien.TabIndex = 2;
            this.radioButton_TimTheoTenNhanVien.TabStop = true;
            this.radioButton_TimTheoTenNhanVien.Text = "Tìm Theo Tên Nhân Viên";
            this.radioButton_TimTheoTenNhanVien.UseVisualStyleBackColor = true;
            // 
            // radioButton_TimTheoMPX
            // 
            this.radioButton_TimTheoMPX.AutoSize = true;
            this.radioButton_TimTheoMPX.Location = new System.Drawing.Point(17, 33);
            this.radioButton_TimTheoMPX.Name = "radioButton_TimTheoMPX";
            this.radioButton_TimTheoMPX.Size = new System.Drawing.Size(127, 17);
            this.radioButton_TimTheoMPX.TabIndex = 2;
            this.radioButton_TimTheoMPX.TabStop = true;
            this.radioButton_TimTheoMPX.Text = "Tìm Theo Tên Mã PX";
            this.radioButton_TimTheoMPX.UseVisualStyleBackColor = true;
            // 
            // txt_TimTheoTenKhachHang
            // 
            this.txt_TimTheoTenKhachHang.Location = new System.Drawing.Point(159, 107);
            this.txt_TimTheoTenKhachHang.Name = "txt_TimTheoTenKhachHang";
            this.txt_TimTheoTenKhachHang.Size = new System.Drawing.Size(239, 20);
            this.txt_TimTheoTenKhachHang.TabIndex = 0;
            this.txt_TimTheoTenKhachHang.EditValueChanged += new System.EventHandler(this.txt_TimTheoTenKhachHang_EditValueChanged);
            // 
            // txt_TimTheoTenNhanVien
            // 
            this.txt_TimTheoTenNhanVien.Location = new System.Drawing.Point(159, 70);
            this.txt_TimTheoTenNhanVien.Name = "txt_TimTheoTenNhanVien";
            this.txt_TimTheoTenNhanVien.Size = new System.Drawing.Size(239, 20);
            this.txt_TimTheoTenNhanVien.TabIndex = 0;
            this.txt_TimTheoTenNhanVien.EditValueChanged += new System.EventHandler(this.txt_TimTheoTenNhanVien_EditValueChanged);
            // 
            // txt_TimTheoMPX
            // 
            this.txt_TimTheoMPX.Location = new System.Drawing.Point(159, 32);
            this.txt_TimTheoMPX.Name = "txt_TimTheoMPX";
            this.txt_TimTheoMPX.Size = new System.Drawing.Size(239, 20);
            this.txt_TimTheoMPX.TabIndex = 0;
            this.txt_TimTheoMPX.EditValueChanged += new System.EventHandler(this.txt_TimTheoMPX_EditValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources._5555599;
            this.pictureBox1.Location = new System.Drawing.Point(435, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UC_Xuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gridControl_DanhSachXuatHang);
            this.Name = "UC_Xuat";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.UC_Xuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DanhSachXuatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoTenKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoTenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoMPX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_DanhSachXuatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RadioButton radioButton_TimTheoTenKhachHang;
        private System.Windows.Forms.RadioButton radioButton_TimTheoTenNhanVien;
        private System.Windows.Forms.RadioButton radioButton_TimTheoMPX;
        private DevExpress.XtraEditors.TextEdit txt_TimTheoTenKhachHang;
        private DevExpress.XtraEditors.TextEdit txt_TimTheoTenNhanVien;
        private DevExpress.XtraEditors.TextEdit txt_TimTheoMPX;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
