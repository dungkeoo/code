namespace Project.Reports
{
    partial class In_HoaDonXuat
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.demoDataSet = new Project.DemoDataSet();
            this.vpxuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_pxuatTableAdapter = new Project.DemoDataSetTableAdapters.v_pxuatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpxuatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vpxuatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project.Reports.RP_HoaDonXuat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(860, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "DemoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vpxuatBindingSource
            // 
            this.vpxuatBindingSource.DataMember = "v_pxuat";
            this.vpxuatBindingSource.DataSource = this.demoDataSet;
            // 
            // v_pxuatTableAdapter
            // 
            this.v_pxuatTableAdapter.ClearBeforeFill = true;
            // 
            // In_HoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Name = "In_HoaDonXuat";
            this.Size = new System.Drawing.Size(860, 450);
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpxuatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vpxuatBindingSource;
        private DemoDataSet demoDataSet;
        private DemoDataSetTableAdapters.v_pxuatTableAdapter v_pxuatTableAdapter;
    }
}
