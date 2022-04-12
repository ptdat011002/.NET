using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    class Class1
    {
        public SqlConnection connection()
        {
            string con_str = $"Data Source = DESKTOP-3IU0BFP\\SQLEXPRESS ; Initial Catalog = PMStore ; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_str);
            return conn;
        }

    }
}
