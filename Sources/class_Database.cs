using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Data;

namespace Giaodiendieukhien.Sources
{
    public static class class_Database
    {
        public static void cmd_SQLWrite(string sqltable_name,
                                              string column1, string data1,
                                              string column2, string data2)       //Phương thức ghi dữ liệu xuống SQL để thực hiện lưu trữ với độ rộng là 2 columns
        {
            // Thiết lập kết nối đến máy chủ SQL
            SqlConnection sql_connect;
            string ServerName = Properties.Settings.Default.Data_ServerName;
            string DatabaseName = Properties.Settings.Default.Data_Name;
            string Login_UserName = Properties.Settings.Default.Data_LoginUser;
            string Password = Properties.Settings.Default.Data_Password;
            string sqlName = @"Data Source=" + ServerName + ";Initial Catalog=" + DatabaseName + ";User ID=" + Login_UserName + ";Password=" + Password;            //Câu lệnh truy cập vào SQL
            sql_connect = new SqlConnection(sqlName);
            sql_connect.Open();
            // Xây dựng truy vấn SQL
            string sql = " INSERT INTO " + sqltable_name + " ("
                + column1 + ","
                + column2 + ")"
                + " VALUES "
                + "("
                + "@" + column1 + ","
                + "@" + column2 + ")";
            using(SqlCommand cmd = new SqlCommand(sql, sql_connect))
            {
                cmd.Parameters.AddWithValue(column1, data1);            //Thêm tham số vào truy vấn
                cmd.Parameters.AddWithValue(column2, data2);
                cmd.ExecuteNonQuery();                                  //Bắt đầu thực hiện truy vấn.
            }
            sql_connect.Close();
        }
        public static void sqlDisplay(string sqlSelect, DataGridView dtgv)          //Phương thức đọc dữ liệu từ SQL
        {
            // Thiết lập kết nối đến máy chủ SQL
            SqlConnection sql_connect;
            string ServerName = Properties.Settings.Default.Data_ServerName;
            string DatabaseName = Properties.Settings.Default.Data_Name;
            string Login_UserName = Properties.Settings.Default.Data_LoginUser;
            string Password = Properties.Settings.Default.Data_Password;
            string sqlName = @"Data Source=" + ServerName + ";Initial Catalog=" + DatabaseName + ";User ID=" + Login_UserName + ";Password=" + Password;
            sql_connect = new SqlConnection(sqlName);
            sql_connect.Open();
            // Đọc dữ liệu và ghi vào table rồi ghi lên Datagridview
            SqlCommand cmd = new SqlCommand(sqlSelect, sql_connect);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgv.DataSource = dt;
            dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sql_connect.Close();
        }
        public static void cmd_SQLWrite1(string sqltable_name,          
                                              string column1, string data1,
                                              string column2, string data2,
                                              string column3, string data3,
                                              string column4, string data4)      //Phương thức ghi dữ liệu xuống SQL để thực hiện lưu trữ với độ rộng là 4 columns
        {
            SqlConnection sql_connect;
            string ServerName = Properties.Settings.Default.Data_ServerName;
            string DatabaseName = Properties.Settings.Default.Data_Name;
            string Login_UserName = Properties.Settings.Default.Data_LoginUser;
            string Password = Properties.Settings.Default.Data_Password;
            string sqlName = @"Data Source=" + ServerName + ";Initial Catalog=" + DatabaseName + ";User ID=" + Login_UserName + ";Password=" + Password;
            sql_connect = new SqlConnection(sqlName);
            sql_connect.Open();
            string sql = " INSERT INTO " + sqltable_name + " ("
                + column1 + ","
                + column2 + ","
                + column3 + ","
                + column4 + ")"
                + " VALUES "
                + "("
                + "@" + column1 + ","
                + "@" + column2 + ","
                + "@" + column3 + ","
                + "@" + column4 + ")";
            using (SqlCommand cmd = new SqlCommand(sql, sql_connect))
            {
                cmd.Parameters.AddWithValue(column1, data1);
                cmd.Parameters.AddWithValue(column2, data2);
                cmd.Parameters.AddWithValue(column3, data3);
                cmd.Parameters.AddWithValue(column4, data4);
                cmd.ExecuteNonQuery();
            }
            sql_connect.Close();
        }
    }
}
