namespace Project.Component
{
    partial class UC_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_KhachHang));
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_DanhSachKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rdbTimTheoMaKH = new System.Windows.Forms.RadioButton();
            this.txt_TimTheoTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txt_TimTheoMaKH = new DevExpress.XtraEditors.TextEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTenKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.txt_TimTheoDiaChiKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.rdbTimTheoTenKH = new System.Windows.Forms.RadioButton();
            this.rdbTimTheoDiaChiKH = new System.Windows.Forms.RadioButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btIn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtdgdg = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DanhSachKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoDiaChiKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btHuy
            // 
            this.btHuy.Image = ((System.Drawing.Image)(resources.GetObject("btHuy.Image")));
            this.btHuy.Location = new System.Drawing.Point(298, 168);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 23);
            this.btHuy.TabIndex = 10;
            this.btHuy.Text = "Hủy";
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btLuu
            // 
            this.btLuu.Image = ((System.Drawing.Image)(resources.GetObject("btLuu.Image")));
            this.btLuu.Location = new System.Drawing.Point(148, 168);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 8;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // gridControl_DanhSachKhachHang
            // 
            this.gridControl_DanhSachKhachHang.Location = new System.Drawing.Point(3, 201);
            this.gridControl_DanhSachKhachHang.MainView = this.gridView1;
            this.gridControl_DanhSachKhachHang.Name = "gridControl_DanhSachKhachHang";
            this.gridControl_DanhSachKhachHang.Size = new System.Drawing.Size(854, 246);
            this.gridControl_DanhSachKhachHang.TabIndex = 7;
            this.gridControl_DanhSachKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterEnabled = false;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl_DanhSachKhachHang;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridView1.Name = "gridView1";
            this.gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã Khách Hàng";
            this.gridColumn2.FieldName = "makhachhang";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên Khách Hàng";
            this.gridColumn3.FieldName = "tenkhachhang";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Địa Chỉ";
            this.gridColumn4.FieldName = "Diachi";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Phone";
            this.gridColumn5.FieldName = "Dienthoai";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Email";
            this.gridColumn6.FieldName = "Email";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // rdbTimTheoMaKH
            // 
            this.rdbTimTheoMaKH.AutoSize = true;
            this.rdbTimTheoMaKH.Location = new System.Drawing.Point(23, 32);
            this.rdbTimTheoMaKH.Name = "rdbTimTheoMaKH";
            this.rdbTimTheoMaKH.Size = new System.Drawing.Size(88, 17);
            this.rdbTimTheoMaKH.TabIndex = 0;
            this.rdbTimTheoMaKH.TabStop = true;
            this.rdbTimTheoMaKH.Text = "Tìm Theo Mã";
            this.rdbTimTheoMaKH.UseVisualStyleBackColor = true;
            // 
            // txt_TimTheoTenKH
            // 
            this.txt_TimTheoTenKH.Location = new System.Drawing.Point(30, 104);
            this.txt_TimTheoTenKH.Name = "txt_TimTheoTenKH";
            this.txt_TimTheoTenKH.Size = new System.Drawing.Size(132, 20);
            this.txt_TimTheoTenKH.TabIndex = 0;
            this.txt_TimTheoTenKH.EditValueChanged += new System.EventHandler(this.txt_TimTheoTenKH_EditValueChanged);
            // 
            // txt_TimTheoMaKH
            // 
            this.txt_TimTheoMaKH.Location = new System.Drawing.Point(30, 55);
            this.txt_TimTheoMaKH.Name = "txt_TimTheoMaKH";
            this.txt_TimTheoMaKH.Size = new System.Drawing.Size(132, 20);
            this.txt_TimTheoMaKH.TabIndex = 0;
            this.txt_TimTheoMaKH.EditValueChanged += new System.EventHandler(this.txt_TimTheoMaKH_EditValueChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(115, 69);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(152, 20);
            this.txtTenKhachHang.TabIndex = 2;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(115, 40);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(152, 20);
            this.txtMaKhachHang.TabIndex = 1;
            // 
            // txt_TimTheoDiaChiKH
            // 
            this.txt_TimTheoDiaChiKH.Location = new System.Drawing.Point(30, 157);
            this.txt_TimTheoDiaChiKH.Name = "txt_TimTheoDiaChiKH";
            this.txt_TimTheoDiaChiKH.Size = new System.Drawing.Size(132, 20);
            this.txt_TimTheoDiaChiKH.TabIndex = 0;
            this.txt_TimTheoDiaChiKH.EditValueChanged += new System.EventHandler(this.txt_TimTheoDiaChiKH_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(18, 123);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Địa Chỉ";
            // 
            // rdbTimTheoTenKH
            // 
            this.rdbTimTheoTenKH.AutoSize = true;
            this.rdbTimTheoTenKH.Location = new System.Drawing.Point(22, 81);
            this.rdbTimTheoTenKH.Name = "rdbTimTheoTenKH";
            this.rdbTimTheoTenKH.Size = new System.Drawing.Size(92, 17);
            this.rdbTimTheoTenKH.TabIndex = 0;
            this.rdbTimTheoTenKH.TabStop = true;
            this.rdbTimTheoTenKH.Text = "Tìm Theo Tên";
            this.rdbTimTheoTenKH.UseVisualStyleBackColor = true;
            // 
            // rdbTimTheoDiaChiKH
            // 
            this.rdbTimTheoDiaChiKH.AutoSize = true;
            this.rdbTimTheoDiaChiKH.Location = new System.Drawing.Point(22, 134);
            this.rdbTimTheoDiaChiKH.Name = "rdbTimTheoDiaChiKH";
            this.rdbTimTheoDiaChiKH.Size = new System.Drawing.Size(107, 17);
            this.rdbTimTheoDiaChiKH.TabIndex = 0;
            this.rdbTimTheoDiaChiKH.TabStop = true;
            this.rdbTimTheoDiaChiKH.Text = "Tìm Theo Địa Chỉ";
            this.rdbTimTheoDiaChiKH.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Location = new System.Drawing.Point(30, 146);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(80, 31);
            this.btXoa.TabIndex = 0;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btIn
            // 
            this.btIn.Location = new System.Drawing.Point(30, 109);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(80, 27);
            this.btIn.TabIndex = 0;
            this.btIn.Text = "In";
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btXoa);
            this.groupControl1.Controls.Add(this.btIn);
            this.groupControl1.Controls.Add(this.btSua);
            this.groupControl1.Controls.Add(this.btThem);
            this.groupControl1.Location = new System.Drawing.Point(3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(131, 197);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Chức Năng";
            // 
            // btSua
            // 
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.Location = new System.Drawing.Point(30, 72);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(80, 31);
            this.btSua.TabIndex = 0;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(30, 32);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 28);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtEmail);
            this.groupControl2.Controls.Add(this.txtPhone);
            this.groupControl2.Controls.Add(this.btHuy);
            this.groupControl2.Controls.Add(this.btLuu);
            this.groupControl2.Controls.Add(this.txtTenKhachHang);
            this.groupControl2.Controls.Add(this.txtMaKhachHang);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtdgdg);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtDiaChi);
            this.groupControl2.Location = new System.Drawing.Point(137, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(524, 196);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Nhập Thông Tin";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(342, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(342, 34);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtPhone.Properties.Mask.BeepOnError = true;
            this.txtPhone.Properties.Mask.EditMask = "(9999)000-000";
            this.txtPhone.Size = new System.Drawing.Size(161, 20);
            this.txtPhone.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(292, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Email";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(292, 40);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Phone";
            // 
            // txtdgdg
            // 
            this.txtdgdg.Location = new System.Drawing.Point(18, 72);
            this.txtdgdg.Name = "txtdgdg";
            this.txtdgdg.Size = new System.Drawing.Size(78, 13);
            this.txtdgdg.TabIndex = 0;
            this.txtdgdg.Text = "Tên Khách Hàng";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Khách Hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(115, 107);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(388, 44);
            this.txtDiaChi.TabIndex = 11;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.rdbTimTheoDiaChiKH);
            this.groupControl3.Controls.Add(this.rdbTimTheoTenKH);
            this.groupControl3.Controls.Add(this.txt_TimTheoDiaChiKH);
            this.groupControl3.Controls.Add(this.rdbTimTheoMaKH);
            this.groupControl3.Controls.Add(this.txt_TimTheoTenKH);
            this.groupControl3.Controls.Add(this.txt_TimTheoMaKH);
            this.groupControl3.Location = new System.Drawing.Point(664, 4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(193, 196);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Tìm Kiếm";
            // 
            // UC_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl_DanhSachKhachHang);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Name = "UC_KhachHang";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.UC_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DanhSachKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoDiaChiKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraGrid.GridControl gridControl_DanhSachKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.RadioButton rdbTimTheoMaKH;
        private DevExpress.XtraEditors.TextEdit txt_TimTheoTenKH;
        private DevExpress.XtraEditors.TextEdit txt_TimTheoMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.TextEdit txtTenKhachHang;
        private DevExpress.XtraEditors.TextEdit txtMaKhachHang;
        private DevExpress.XtraEditors.TextEdit txt_TimTheoDiaChiKH;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.RadioButton rdbTimTheoTenKH;
        private System.Windows.Forms.RadioButton rdbTimTheoDiaChiKH;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btIn;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl txtdgdg;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.ButtonEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtEmail;
    }
}
