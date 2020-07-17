namespace Project.Component
{
    partial class UC_Saoluu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtduongdan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_phuchoi = new System.Windows.Forms.Button();
            this.bt_chon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtduongdan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_phuchoi);
            this.groupBox1.Controls.Add(this.bt_chon);
            this.groupBox1.Location = new System.Drawing.Point(15, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao lưu dữ liệu";
            // 
            // txtduongdan
            // 
            this.txtduongdan.Location = new System.Drawing.Point(241, 134);
            this.txtduongdan.Name = "txtduongdan";
            this.txtduongdan.Size = new System.Drawing.Size(502, 26);
            this.txtduongdan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dường dẫn lưu dữ liệu:";
            // 
            // bt_phuchoi
            // 
            this.bt_phuchoi.Location = new System.Drawing.Point(441, 313);
            this.bt_phuchoi.Name = "bt_phuchoi";
            this.bt_phuchoi.Size = new System.Drawing.Size(142, 42);
            this.bt_phuchoi.TabIndex = 0;
            this.bt_phuchoi.Text = "Thực thi";
            this.bt_phuchoi.UseVisualStyleBackColor = true;
            this.bt_phuchoi.Click += new System.EventHandler(this.bt_phuchoi_Click);
            // 
            // bt_chon
            // 
            this.bt_chon.Location = new System.Drawing.Point(133, 313);
            this.bt_chon.Name = "bt_chon";
            this.bt_chon.Size = new System.Drawing.Size(142, 42);
            this.bt_chon.TabIndex = 0;
            this.bt_chon.Text = "Chọn";
            this.bt_chon.UseVisualStyleBackColor = true;
            this.bt_chon.Click += new System.EventHandler(this.bt_chon_Click);
            // 
            // UC_Saoluu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Saoluu";
            this.Size = new System.Drawing.Size(827, 433);
            this.Load += new System.EventHandler(this.UC_Saoluu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtduongdan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_phuchoi;
        private System.Windows.Forms.Button bt_chon;
    }
}
