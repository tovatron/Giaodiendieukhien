using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Giaodiendieukhien
{
    class TruyvanLogin
    {
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<Accounts> Loginaccounts(string query, string username, string password)
        {
            List<Accounts> accounts = new List<Accounts>();

            using (SqlConnection sqlConnection = ConnectionLogin.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Username", username);
                sqlCommand.Parameters.AddWithValue("@Password", password);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    accounts.Add(new Accounts(dataReader.GetString(0),dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }

            return accounts;
        }
        private string roleaccount;
        public string Roles(string query, string username, string password)
        {
            string role = "";
            using (SqlConnection sqlConnection = ConnectionLogin.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Username", username);
                sqlCommand.Parameters.AddWithValue("@Password", password);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if(dataReader.Read())
                {
                    role = dataReader.GetString(0);
                }
                sqlConnection.Close();
            }
                return role;
        }
    }
}
