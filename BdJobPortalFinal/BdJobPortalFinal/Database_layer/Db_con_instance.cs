using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace BdJobPortalFinal.Database_layer
{
    public class Db_con_instance
    {
        private SqlConnection conn = new SqlConnection();

        public SqlConnection GetConn()
        {
            return conn;
        }

        public Db_con_instance()
        {
            DefineConnectionString();

        }
        public void DefineConnectionString()
        {
            conn.ConnectionString = "Data Source=localhost\\sqlexpress;" +
             "Initial Catalog=eJobFinderDB;" +
             "Integrated Security=SSPI;";
        }

    }
}