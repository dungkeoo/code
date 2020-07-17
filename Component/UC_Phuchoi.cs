using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Project.Component
{
    public partial class UC_Phuchoi : UserControl
    {
        public UC_Phuchoi()
        {
            InitializeComponent();
        }
        FileDialog dl;
        private void bt_chon_Click(object sender, EventArgs e)
        {
            dl = new SaveFileDialog();
            dl.Filter = "File type(*.bak)|*.bak";
            dl.DefaultExt = "bak";
            if (dl.ShowDialog() == DialogResult.OK)
            {
                txtduongdan.Text = dl.FileName;
            }
        }

        private void bt_phuchoi_Click(object sender, EventArgs e)
        {
            if (txtduongdan.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Bạn chưa chọn file phục hồi!");
                txtduongdan.Focus();
                return;
            }
            //StreamReader Re = File.OpenText("Config.txt");
            //string connectionstring = Re.ReadLine();
           // Re.Close();
            //SqlConnection connection1 = new SqlConnection();
           // connection1 = new SqlConnection(connectionstring);

            SqlConnection connection1 = new Helper().GetConnect();

            try
            {
                connection1.Open();
                SqlCommand cmd = new SqlCommand("ALTER DATABASE CUAHANGBANXEMAY SET OFFLINE WITH ROLLBACK IMMEDIATE USE master RESTORE DATABASE CUAHANGBANXEMAY FROM DISK='" + txtduongdan.Text + "' WITH REPLACE ALTER DATABASE CUAHANGBANXEMAY SET ONLINE ", connection1);
                cmd.ExecuteNonQuery();
                connection1.Close();
                MessageBox.Show("Phục hồi thành công");
               
            }
            catch
            {
                MessageBox.Show("Phục hồi thất bại");
            }       
         
        }
           
        private void UC_Phuchoi_Load(object sender, EventArgs e)
        {

        }
    }
}
