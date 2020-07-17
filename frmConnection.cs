using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using Microsoft.Win32;

namespace Project
{
    public partial class frmConnection : Office2007Form
    {
        
        public frmConnection()
        {
            InitializeComponent();
        }
        private void frmConnection_Load(object sender, EventArgs e)
        {
            cmbAuthentication.SelectedIndex = 0;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbAuthentication.SelectedIndex == 0)
             Helper.WriteFile(txtServer.Text,cmbDatabase.Text,"","");
            else Helper.WriteFile(txtServer.Text, cmbDatabase.Text, txtUsername.Text,txtPassword.Text);
            this.Close();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            //Quyền Windows
            if (cmbAuthentication.SelectedIndex == 0)
            {
                cmbDatabase.Items.Clear();
                SqlConnection con = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;Integrated Security=True;");
                SqlCommand cmd = new SqlCommand("SP_DATABASES", con);
                //SP_DATABASES là một store procedure có sẵn của sql server để lấy ra tất cả csdl trong sql server
                SqlDataReader reader;               
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbDatabase.Items.Add(reader[0].ToString());
                    }
                    cmbDatabase.Enabled = true;
                    MessageBoxEx.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBoxEx.Show("Lỗi, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();

                    con.Dispose();
                    cmd.Dispose();
                }
            }

            //Quyền SQL Server
            if (cmbAuthentication.SelectedIndex == 1)
            {
                cmbDatabase.Items.Clear();
                SqlConnection con = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;User Id=" + txtUsername.Text + ";Password=" + txtPassword.Text + ";");
                SqlCommand cmd = new SqlCommand("SP_DATABASES", con);
                SqlDataReader reader;
                
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbDatabase.Items.Add(reader[0].ToString());
                    }
                    cmbDatabase.Enabled = true;
                    MessageBoxEx.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBoxEx.Show("Lỗi, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();

                    con.Dispose();
                    cmd.Dispose();
                }
            }
        }
        private void cmbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthentication.SelectedIndex == 0)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = true;
        }
    }
}