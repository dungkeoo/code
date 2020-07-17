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
    public partial class UC_Saoluu : UserControl
    {
        public UC_Saoluu()
        {
            InitializeComponent();
        }
        FileDialog dl;
        private void UC_Saoluu_Load(object sender, EventArgs e)
        {

        }

        private void bt_chon_Click(object sender, EventArgs e)
        {
            dl = new SaveFileDialog();
            dl.Filter = "File type(*.bak)|*.bak";
            dl.DefaultExt = "bak";
            dl.FileName = DateTime.Now.ToString("dd-MM-yyyy-hh") + ".bak";
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
            try 
            {
               // StreamReader Re = File.OpenText("Config.txt");
              //  string connectionstring = Re.ReadLine();
             //   Re.Close();
              //  SqlConnection connection1 = new SqlConnection();
               // connection1 = new SqlConnection(connectionstring);

                SqlConnection connection1 = new Helper().GetConnect();

                connection1.Open();
                SqlCommand cmd = new SqlCommand("BACKUP DATABASE CUAHANGBANXEMAY TO DISK='" + txtduongdan.Text + "'", connection1);
                cmd.ExecuteNonQuery();
                connection1.Close();
                MessageBox.Show("Sao lưu thành công");
            }
            catch
            {
                MessageBox.Show("Hãy chọn ổ D hoặc E!");
            }
        }
    }

    }

