namespace Project.Reports
{
    partial class RP_NhapHang
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bt_Xem = new DevExpress.XtraEditors.SimpleButton();
            this.cb_Nam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tháng = new System.Windows.Forms.Label();
            this.cb_Thang = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.demoDataSet = new Project.DemoDataSet();
            this.vDanhSachPNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DanhSachPNhapTableAdapter = new Project.DemoDataSetTableAdapters.v_DanhSachPNhapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDanhSachPNhapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Xem
            // 
            this.bt_Xem.Location = new System.Drawing.Point(482, 8);
            this.bt_Xem.Name = "bt_Xem";
            this.bt_Xem.Size = new System.Drawing.Size(75, 23);
            this.bt_Xem.TabIndex = 10;
            this.bt_Xem.Text = "Xem";
            this.bt_Xem.Click += new System.EventHandler(this.bt_Xem_Click);
            // 
            // cb_Nam
            // 
            this.cb_Nam.FormattingEnabled = true;
            this.cb_Nam.Location = new System.Drawing.Point(373, 10);
            this.cb_Nam.Name = "cb_Nam";
            this.cb_Nam.Size = new System.Drawing.Size(83, 21);
            this.cb_Nam.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Năm";
            // 
            // Tháng
            // 
            this.Tháng.AutoSize = true;
            this.Tháng.Location = new System.Drawing.Point(206, 13);
            this.Tháng.Name = "Tháng";
            this.Tháng.Size = new System.Drawing.Size(38, 13);
            this.Tháng.TabIndex = 7;
            this.Tháng.Text = "Tháng";
            // 
            // cb_Thang
            // 
            this.cb_Thang.FormattingEnabled = true;
            this.cb_Thang.Location = new System.Drawing.Point(250, 10);
            this.cb_Thang.Name = "cb_Thang";
            this.cb_Thang.Size = new System.Drawing.Size(71, 21);
            this.cb_Thang.TabIndex = 6;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vDanhSachPNhapBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project.Reports.RP_NhapHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(860, 392);
            this.reportViewer1.TabIndex = 5;
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "DemoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vDanhSachPNhapBindingSource
            // 
            this.vDanhSachPNhapBindingSource.DataMember = "v_DanhSachPNhap";
            this.vDanhSachPNhapBindingSource.DataSource = this.demoDataSet;
            // 
            // v_DanhSachPNhapTableAdapter
            // 
            this.v_DanhSachPNhapTableAdapter.ClearBeforeFill = true;
            // 
            // RP_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_Xem);
            this.Controls.Add(this.cb_Nam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tháng);
            this.Controls.Add(this.cb_Thang);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RP_NhapHang";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.RP_NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDanhSachPNhapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bt_Xem;
        private System.Windows.Forms.ComboBox cb_Nam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tháng;
        private System.Windows.Forms.ComboBox cb_Thang;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vDanhSachPNhapBindingSource;
        private DemoDataSet demoDataSet;
        private DemoDataSetTableAdapters.v_DanhSachPNhapTableAdapter v_DanhSachPNhapTableAdapter;
    }
}
