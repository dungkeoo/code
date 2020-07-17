using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Project.Connection
{
    class GetData
    {

    private DataTable dt;
    
    string _error;
   
    public string Error
        {
            get { return _error; }
            set { _error = value; }
        }
              

        SqlConnection conn = new Helper().GetConnect();

       // SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=CUAHANGBANXEMAY;Integrated Security=True");
       // SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QUANLYXEMAY;Integrated Security=True");

        
        public bool Connect()
        {
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Error = e.Message;
                return false;
            }
            return true;
        }
        void DisConnect()
        {
            conn.Close();
        }


        public DataTable getdata(string sqlcommand)
        {
            if (conn.State == ConnectionState.Closed)
                if (!Connect()) return null;
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(sqlcommand, conn);
                dt = new DataTable();
                sda.Fill(dt);
                DisConnect();
                return dt;
            }
            catch (Exception e)
            {
                Error = e.Message;
                DisConnect();
                return null;
            }



        }

        // Lấy mã cuối cùng
        public string GetLastID(string nameTable, string nameFiled)
        {
            Connect();
            string sql = "SELECT TOP (1) " + nameFiled + " FROM " + nameTable + " ORDER BY " + nameFiled + " DESC";
            getdata(sql);
            // thực hiện câu truy vấn trên
            return dt.Rows[0][nameFiled].ToString();
        }

        public bool UpdateData(string sqlcommand)
        {
            if (conn.State == ConnectionState.Closed)
                if (!Connect()) return false;
            SqlCommand sqlUpdate = new SqlCommand(sqlcommand, conn);
            int kq = 0;
            try
            {
                kq = sqlUpdate.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Error = e.Message;
                return false;
            }
            DisConnect();
            if (kq <= 0) return false;
            return true;
        }
                     

    }
}
