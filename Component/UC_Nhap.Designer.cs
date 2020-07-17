namespace Project.Component
{
    partial class UC_Nhap
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
            this.gridControl_DanhSachNhapHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.radioButton_TimTheoTenNV = new System.Windows.Forms.RadioButton();
            this.radioButton_TimTheoTenNCC = new System.Windows.Forms.RadioButton();
            this.radioButton_TimTheoMPN = new System.Windows.Forms.RadioButton();
            this.txt_TimTheoTenNV = new DevExpress.XtraEditors.TextEdit();
            this.txt_TimTheoTenNCC = new DevExpress.XtraEditors.TextEdit();
            this.txt_TimTheoMPN = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DanhSachNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoTenNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoMPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_DanhSachNhapHang
            // 
            this.gridControl_DanhSachNhapHang.Location = new System.Drawing.Point(3, 155);
            this.gridControl_DanhSachNhapHang.MainView = this.gridView1;
            this.gridControl_DanhSachNhapHang.Name = "gridControl_DanhSachNhapHang";
            this.gridControl_DanhSachNhapHang.Size = new System.Drawing.Size(854, 295);
            this.gridControl_DanhSachNhapHang.TabIndex = 8;
            this.gridControl_DanhSachNhapHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterEnabled = false;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl_DanhSachNhapHang;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridView1.Name = "gridView1";
            this.gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.radioButton_TimTheoTenNV);
            this.groupControl2.Controls.Add(this.radioButton_TimTheoTenNCC);
            this.groupControl2.Controls.Add(this.radioButton_TimTheoMPN);
            this.groupControl2.Controls.Add(this.txt_TimTheoTenNV);
            this.groupControl2.Controls.Add(this.txt_TimTheoTenNCC);
            this.groupControl2.Controls.Add(this.txt_TimTheoMPN);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(426, 146);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Tìm Kiếm";
            // 
            // radioButton_TimTheoTenNV
            // 
            this.radioButton_TimTheoTenNV.AutoSize = true;
            this.radioButton_TimTheoTenNV.Location = new System.Drawing.Point(17, 110);
            this.radioButton_TimTheoTenNV.Name = "radioButton_TimTheoTenNV";
            this.radioButton_TimTheoTenNV.Size = new System.Drawing.Size(110, 17);
            this.radioButton_TimTheoTenNV.TabIndex = 2;
            this.radioButton_TimTheoTenNV.TabStop = true;
            this.radioButton_TimTheoTenNV.Text = "Tìm Theo Tên NV";
            this.radioButton_TimTheoTenNV.UseVisualStyleBackColor = true;
            // 
            // radioButton_TimTheoTenNCC
            // 
            this.radioButton_TimTheoTenNCC.AutoSize = true;
            this.radioButton_TimTheoTenNCC.Location = new System.Drawing.Point(17, 71);
            this.radioButton_TimTheoTenNCC.Name = "radioButton_TimTheoTenNCC";
            this.radioButton_TimTheoTenNCC.Size = new System.Drawing.Size(132, 17);
            this.radioButton_TimTheoTenNCC.TabIndex = 2;
            this.radioButton_TimTheoTenNCC.TabStop = true;
            this.radioButton_TimTheoTenNCC.Text = "Tìm Theo Tên Nha CC";
            this.radioButton_TimTheoTenNCC.UseVisualStyleBackColor = true;
            // 
            // radioButton_TimTheoMPN
            // 
            this.radioButton_TimTheoMPN.AutoSize = true;
            this.radioButton_TimTheoMPN.Location = new System.Drawing.Point(17, 33);
            this.radioButton_TimTheoMPN.Name = "radioButton_TimTheoMPN";
            this.radioButton_TimTheoMPN.Size = new System.Drawing.Size(125, 17);
            this.radioButton_TimTheoMPN.TabIndex = 2;
            this.radioButton_TimTheoMPN.TabStop = true;
            this.radioButton_TimTheoMPN.Text = "Tìm Theo Tên MaPN";
            this.radioButton_TimTheoMPN.UseVisualStyleBackColor = true;
            // 
            // txt_TimTheoTenNV
            // 
            this.txt_TimTheoTenNV.Location = new System.Drawing.Point(159, 107);
            this.txt_TimTheoTenNV.Name = "txt_TimTheoTenNV";
            this.txt_TimTheoTenNV.Size = new System.Drawing.Size(239, 20);
            this.txt_TimTheoTenNV.TabIndex = 0;
            this.txt_TimTheoTenNV.EditValueChanged += new System.EventHandler(this.txt_TimTheoTenNV_EditValueChanged);
            // 
            // txt_TimTheoTenNCC
            // 
            this.txt_TimTheoTenNCC.Location = new System.Drawing.Point(159, 70);
            this.txt_TimTheoTenNCC.Name = "txt_TimTheoTenNCC";
            this.txt_TimTheoTenNCC.Size = new System.Drawing.Size(239, 20);
            this.txt_TimTheoTenNCC.TabIndex = 0;
            this.txt_TimTheoTenNCC.EditValueChanged += new System.EventHandler(this.txt_TimTheoTenNCC_EditValueChanged);
            // 
            // txt_TimTheoMPN
            // 
            this.txt_TimTheoMPN.Location = new System.Drawing.Point(159, 32);
            this.txt_TimTheoMPN.Name = "txt_TimTheoMPN";
            this.txt_TimTheoMPN.Size = new System.Drawing.Size(239, 20);
            this.txt_TimTheoMPN.TabIndex = 0;
            this.txt_TimTheoMPN.EditValueChanged += new System.EventHandler(this.txt_TimTheoMPN_EditValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources._5555599;
            this.pictureBox1.Location = new System.Drawing.Point(435, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UC_Nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gridControl_DanhSachNhapHang);
            this.Name = "UC_Nhap";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.UC_Nhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DanhSachNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoTenNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimTheoMPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_DanhSachNhapHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RadioButton radioButton_TimTheoTenNV;
        private System.Windows.Forms.RadioButton radioButton_TimTheoTenNCC;
        private System.Windows.Forms.RadioButton radioButton_TimTheoMPN;
        private DevExpress.XtraEditors.TextEdit txt_TimTheoTenNV;
        private DevExpress.XtraEditors.TextEdit txt_TimTheoTenNCC;
        private DevExpress.XtraEditors.TextEdit txt_TimTheoMPN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
