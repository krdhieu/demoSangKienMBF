using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace do_an_demo
{
    class CRUD
    {
        

        public DataTable getDataTable(string sqlQuery) { 
            ConnectDB con = new ConnectDB();
            try
            {
                con.openConnect();
                DataSet dataSet = new DataSet();
                SqlCommand command = new SqlCommand(sqlQuery, con.con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet);
                DataTable dataTable = dataSet.Tables[0];
                return dataTable;
            }
            catch
            {
                return null;
            }
        }


        public bool execSqlQuery(string sqlQuery)
        {
            ConnectDB con = new ConnectDB();
            try
            {
                con.openConnect();
                SqlCommand command = new SqlCommand(sqlQuery,con.con);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public SqlDataReader ReadData(string sql)
        {
            ConnectDB con = new ConnectDB();
            SqlDataReader Data;
            con.openConnect();
            SqlCommand cmd = new SqlCommand(sql, con.con);
            Data = cmd.ExecuteReader();

            return Data;
        }

    }
}
