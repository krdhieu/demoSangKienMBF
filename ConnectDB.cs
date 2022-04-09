using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace do_an_demo
{   
    class ConnectDB
    {
        public SqlConnection con = new SqlConnection();
        string connectString = @"Data Source=DESKTOP-VK75285\SQLEXPRESS;Initial Catalog=SangKienMBF;Integrated Security=True";


        public bool openConnect()
        {
            try
            {
                con.ConnectionString = connectString;
                con.Open();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public void closeConnect()
        {
            con.Close();
        }

    }
}
