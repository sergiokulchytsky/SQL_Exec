using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataLib
{
    public class DB
    {
        SqlConnection myConnection = new SqlConnection("user id=ser; password=123456; database=AdventureWorksDW2014; server=KITKAT;");
        SqlCommand comm = new SqlCommand();
        public DataTable Read(String SQL)
        {
             myConnection.Open();
                    comm.Connection = myConnection;
                    comm.CommandText = SQL;
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            myConnection.Close();
                            return dt;
                        }
                        else
                        {
                            throw new Exception("NOT SELECT");
                        }
                    }
                   
        }
    }

}
