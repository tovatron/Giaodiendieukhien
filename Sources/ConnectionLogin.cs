using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Giaodiendieukhien
{
    class ConnectionLogin
    {
        private static string StringConnection = @"Data Source=.\SQLEXPRESS;Initial Catalog=Login_account;User ID=sa;Integrated Security = True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(StringConnection);
        }
    }
}
