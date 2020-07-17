namespace Project.Component
{
    partial class UC_Chitietbaohanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Chitietbaohanh));
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_TimTheoMa = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl_danhsachcttbh = new DevExpress.XtraGrid.GridControl();
            this.rdbTimTheomachitiet = new System.Windows.Forms.RadioButton();
            this.txt_TimTheongaybaohanh = new DevExpress.XtraEditors.TextEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rdbTimTheoMa = new System.Windows.Forms.RadioButton();
            this.txt_TimTheomachitiet = new DevExpress.XtraEditors.TextEdit();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btIn = new DevExpress.XtraEditors.SimpleButton();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.rdbTimTheongaybh = new System.Windows.Forms.RadioButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtdgdg = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtnoidungbh = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtmaphieubh = new System.Windows.Forms.ComboBox();
            this.txtMachitietbh = new System.Windows.Forms.ComboBox();
            this.txt_thoigianbh = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_danhsachcttbh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheongaybaohanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheomachitiet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnoidungbh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_thoigianbh.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_thoigianbh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            // 
            // txt_TimTheoMa
            // 
            this.txt_TimTheoMa.Location = new System.Drawing.Point(45, 85);
            this.txt_TimTheoMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TimTheoMa.Name = "txt_TimTheoMa";
            this.txt_TimTheoMa.Size = new System.Drawing.Size(198, 26);
            this.txt_TimTheoMa.TabIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterEnabled = false;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl_danhsachcttbh;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridView1.Name = "gridView1";
            this.gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã CTBH";
            this.gridColumn2.FieldName = "MACTBH";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã PBH";
            this.gridColumn3.FieldName = "MAPHIEUBH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "NGÀYBH";
            this.gridColumn4.FieldName = "NGAYBH";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Nội dung bảo hành";
            this.gridColumn5.FieldName = "NOIDUNGBH";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridControl_danhsachcttbh
            // 
            this.gridControl_danhsachcttbh.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControl_danhsachcttbh.Location = new System.Drawing.Point(14, 328);
            this.gridControl_danhsachcttbh.MainView = this.gridView1;
            this.gridControl_danhsachcttbh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControl_danhsachcttbh.Name = "gridControl_danhsachcttbh";
            this.gridControl_danhsachcttbh.Size = new System.Drawing.Size(1260, 683);
            this.gridControl_danhsachcttbh.TabIndex = 15;
            this.gridControl_danhsachcttbh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // rdbTimTheomachitiet
            // 
            this.rdbTimTheomachitiet.AutoSize = true;
            this.rdbTimTheomachitiet.Location = new System.Drawing.Point(33, 125);
            this.rdbTimTheomachitiet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbTimTheomachitiet.Name = "rdbTimTheomachitiet";
            this.rdbTimTheomachitiet.Size = new System.Drawing.Size(171, 24);
            this.rdbTimTheomachitiet.TabIndex = 0;
            this.rdbTimTheomachitiet.TabStop = true;
            this.rdbTimTheomachitiet.Text = "Tìm theo mã chi tiết";
            this.rdbTimTheomachitiet.UseVisualStyleBackColor = true;
            // 
            // txt_TimTheongaybaohanh
            // 
            this.txt_TimTheongaybaohanh.Location = new System.Drawing.Point(45, 242);
            this.txt_TimTheongaybaohanh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TimTheongaybaohanh.Name = "txt_TimTheongaybaohanh";
            this.txt_TimTheongaybaohanh.Size = new System.Drawing.Size(198, 26);
            this.txt_TimTheongaybaohanh.TabIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Name = "gridColumn7";
            // 
            // rdbTimTheoMa
            // 
            this.rdbTimTheoMa.AutoSize = true;
            this.rdbTimTheoMa.Location = new System.Drawing.Point(33, 49);
            this.rdbTimTheoMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbTimTheoMa.Name = "rdbTimTheoMa";
            this.rdbTimTheoMa.Size = new System.Drawing.Size(192, 24);
            this.rdbTimTheoMa.TabIndex = 0;
            this.rdbTimTheoMa.TabStop = true;
            this.rdbTimTheoMa.Text = "Tìm theo mã bảo hành";
            this.rdbTimTheoMa.UseVisualStyleBackColor = true;
            // 
            // txt_TimTheomachitiet
            // 
            this.txt_TimTheomachitiet.Location = new System.Drawing.Point(45, 160);
            this.txt_TimTheomachitiet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TimTheomachitiet.Name = "txt_TimTheomachitiet";
            this.txt_TimTheomachitiet.Size = new System.Drawing.Size(198, 26);
            this.txt_TimTheomachitiet.TabIndex = 0;
            // 
            // btHuy
            // 
            this.btHuy.Image = ((System.Drawing.Image)(resources.GetObject("btHuy.Image")));
            this.btHuy.Location = new System.Drawing.Point(447, 258);
            this.btHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(112, 35);
            this.btHuy.TabIndex = 10;
            this.btHuy.Text = "Hủy";
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btIn
            // 
            this.btIn.Location = new System.Drawing.Point(36, 178);
            this.btIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(117, 35);
            this.btIn.TabIndex = 0;
            this.btIn.Text = "In Danh Sách";
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // btSua
            // 
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.Location = new System.Drawing.Point(36, 115);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(117, 35);
            this.btSua.TabIndex = 0;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btXoa);
            this.groupControl1.Controls.Add(this.btIn);
            this.groupControl1.Controls.Add(this.btSua);
            this.groupControl1.Controls.Add(this.btThem);
            this.groupControl1.Location = new System.Drawing.Point(14, 15);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(196, 303);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Chức Năng";
            // 
            // btXoa
            // 
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Location = new System.Drawing.Point(36, 237);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(117, 35);
            this.btXoa.TabIndex = 0;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.Location = new System.Drawing.Point(36, 54);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(117, 35);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btLuu
            // 
            this.btLuu.Image = ((System.Drawing.Image)(resources.GetObject("btLuu.Image")));
            this.btLuu.Location = new System.Drawing.Point(222, 258);
            this.btLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(112, 35);
            this.btLuu.TabIndex = 8;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.rdbTimTheongaybh);
            this.groupControl3.Controls.Add(this.rdbTimTheomachitiet);
            this.groupControl3.Controls.Add(this.txt_TimTheongaybaohanh);
            this.groupControl3.Controls.Add(this.rdbTimTheoMa);
            this.groupControl3.Controls.Add(this.txt_TimTheomachitiet);
            this.groupControl3.Controls.Add(this.txt_TimTheoMa);
            this.groupControl3.Location = new System.Drawing.Point(1006, 16);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(290, 302);
            this.groupControl3.TabIndex = 14;
            this.groupControl3.Text = "Tìm Kiếm";
            // 
            // rdbTimTheongaybh
            // 
            this.rdbTimTheongaybh.AutoSize = true;
            this.rdbTimTheongaybh.Location = new System.Drawing.Point(33, 206);
            this.rdbTimTheongaybh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbTimTheongaybh.Name = "rdbTimTheongaybh";
            this.rdbTimTheongaybh.Size = new System.Drawing.Size(204, 24);
            this.rdbTimTheongaybh.TabIndex = 0;
            this.rdbTimTheongaybh.TabStop = true;
            this.rdbTimTheongaybh.Text = "Tìm theo ngày bảo hành";
            this.rdbTimTheongaybh.UseVisualStyleBackColor = true;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(27, 171);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(136, 19);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Nội dung bảo hành";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(399, 74);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(138, 19);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Thời gian bảo hành";
            // 
            // txtdgdg
            // 
            this.txtdgdg.Location = new System.Drawing.Point(27, 93);
            this.txtdgdg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdgdg.Name = "txtdgdg";
            this.txtdgdg.Size = new System.Drawing.Size(135, 19);
            this.txtdgdg.TabIndex = 0;
            this.txtdgdg.Text = "Mã phiếu bảo hành";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 44);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(143, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã chi tiết bảo hành";
            // 
            // txtnoidungbh
            // 
            this.txtnoidungbh.Location = new System.Drawing.Point(178, 124);
            this.txtnoidungbh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnoidungbh.Name = "txtnoidungbh";
            this.txtnoidungbh.Size = new System.Drawing.Size(582, 124);
            this.txtnoidungbh.TabIndex = 11;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtmaphieubh);
            this.groupControl2.Controls.Add(this.txtMachitietbh);
            this.groupControl2.Controls.Add(this.btHuy);
            this.groupControl2.Controls.Add(this.btLuu);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtdgdg);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtnoidungbh);
            this.groupControl2.Controls.Add(this.txt_thoigianbh);
            this.groupControl2.Location = new System.Drawing.Point(216, 16);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(786, 302);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "Nhập Thông Tin";
            // 
            // txtmaphieubh
            // 
            this.txtmaphieubh.FormattingEnabled = true;
            this.txtmaphieubh.Location = new System.Drawing.Point(178, 88);
            this.txtmaphieubh.Name = "txtmaphieubh";
            this.txtmaphieubh.Size = new System.Drawing.Size(196, 28);
            this.txtmaphieubh.TabIndex = 13;
            // 
            // txtMachitietbh
            // 
            this.txtMachitietbh.FormattingEnabled = true;
            this.txtMachitietbh.Location = new System.Drawing.Point(178, 44);
            this.txtMachitietbh.Name = "txtMachitietbh";
            this.txtMachitietbh.Size = new System.Drawing.Size(196, 28);
            this.txtMachitietbh.TabIndex = 13;
            // 
            // txt_thoigianbh
            // 
            this.txt_thoigianbh.EditValue = null;
            this.txt_thoigianbh.Location = new System.Drawing.Point(545, 71);
            this.txt_thoigianbh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_thoigianbh.Name = "txt_thoigianbh";
            this.txt_thoigianbh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_thoigianbh.Properties.Mask.EditMask = "";
            this.txt_thoigianbh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txt_thoigianbh.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_thoigianbh.Size = new System.Drawing.Size(209, 26);
            this.txt_thoigianbh.TabIndex = 12;
            // 
            // UC_Chitietbaohanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl_danhsachcttbh);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Name = "UC_Chitietbaohanh";
            this.Size = new System.Drawing.Size(1288, 606);
            this.Load += new System.EventHandler(this.UC_Chitietbaohanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_danhsachcttbh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheongaybaohanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheomachitiet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnoidungbh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_thoigianbh.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_thoigianbh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.TextEdit txt_TimTheoMa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl_danhsachcttbh;
        private System.Windows.Forms.RadioButton rdbTimTheomachitiet;
        private DevExpress.XtraEditors.TextEdit txt_TimTheongaybaohanh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.RadioButton rdbTimTheoMa;
        private DevExpress.XtraEditors.TextEdit txt_TimTheomachitiet;
        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btIn;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.RadioButton rdbTimTheongaybh;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl txtdgdg;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtnoidungbh;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.DateEdit txt_thoigianbh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.ComboBox txtmaphieubh;
        private System.Windows.Forms.ComboBox txtMachitietbh;

    }
}
