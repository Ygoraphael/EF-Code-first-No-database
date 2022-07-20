using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_no_database
{
    public class SqlHelper
    {
        SqlConnection cn;
        public SqlHelper(string ConnectionString)
        {
            cn = new SqlConnection(ConnectionString);
        }
        public bool IsConection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }
    }

}
