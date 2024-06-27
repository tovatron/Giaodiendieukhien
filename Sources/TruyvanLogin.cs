using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace Giaodiendieukhien
{
    class TruyvanLogin
    {
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        
        // Định nghĩa phương thức Loginaccounts (query: truy vấn về SQL, username: gán username từ SQL, password: gán pass từ SQL)
        public List<Accounts> Loginaccounts(string query, string username, string password)
        {
            List<Accounts> accounts = new List<Accounts>(); // Tạo danh sách đối tượng List<Accounts> mới

            // Truy cập vào SQL và đọc giá trị
            using (SqlConnection sqlConnection = ConnectionLogin.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);      //Truy vấn
                sqlCommand.Parameters.AddWithValue("@Username", username);
                sqlCommand.Parameters.AddWithValue("@Password", password);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())          
                {
                    accounts.Add(new Accounts(dataReader.GetString(0),dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }

            return accounts;             // Đọc giá trị username và password truy vấn trong sql rồi trả về list accounts
        }
        // Định nghĩa phương thức Roles (query: truy vấn về SQL, username: gán username từ SQL, password: gán password từ SQL)
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
                return role;            // Đọc giá trị role truy vấn trong sql rồi trả về giá trị role
        }
    }
}
