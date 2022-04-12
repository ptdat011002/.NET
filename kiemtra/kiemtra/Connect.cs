using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace kiemtra
{
    class Connect
    {
        public SqlConnection connection()
        {
            // string con_str = $"Data Source = DESKTOP-3IU0BFP\\SQLEXPRESS ; Initial Catalog = simthe ; Integrated Security = SSPI";
            string con_str = $"Data Source = DESKTOP-3IU0BFP\\SQLEXPRESS ; Initial Catalog = sanbay ; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_str);
            return conn;
        }
    }
}
