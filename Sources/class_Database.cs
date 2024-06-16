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
                                              string column2, string data2)
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
                + column2 + ")"
                + " VALUES "
                + "("
                + "@" + column1 + ","
                + "@" + column2 + ")";
            using(SqlCommand cmd = new SqlCommand(sql, sql_connect))
            {
                cmd.Parameters.AddWithValue(column1, data1);
                cmd.Parameters.AddWithValue(column2, data2);
                cmd.ExecuteNonQuery();
            }
            sql_connect.Close();
        }
        public static void sqlDisplay(string sqlSelect, DataGridView dtgv)
        {
            SqlConnection sql_connect;
            string ServerName = Properties.Settings.Default.Data_ServerName;
            string DatabaseName = Properties.Settings.Default.Data_Name;
            string Login_UserName = Properties.Settings.Default.Data_LoginUser;
            string Password = Properties.Settings.Default.Data_Password;
            string sqlName = @"Data Source=" + ServerName + ";Initial Catalog=" + DatabaseName + ";User ID=" + Login_UserName + ";Password=" + Password;
            sql_connect = new SqlConnection(sqlName);
            sql_connect.Open();
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
                                              string column4, string data4)
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
        public static void sqlDisplay1(string query1, string query2, string query3, DataGridView dtgv)
        {
            SqlConnection sql_connect;
            string ServerName = Properties.Settings.Default.Data_ServerName;
            string DatabaseName = Properties.Settings.Default.Data_Name;
            string Login_UserName = Properties.Settings.Default.Data_LoginUser;
            string Password = Properties.Settings.Default.Data_Password;
            string sqlName = @"Data Source=" + ServerName + ";Initial Catalog=" + DatabaseName + ";User ID=" + Login_UserName + ";Password=" + Password;
            sql_connect = new SqlConnection(sqlName);
            sql_connect.Open();
            DataTable mergedTable = new DataTable();
            // Add columns to mergedTable as needed
            for (int i = 1; i <= 6; i++)
                mergedTable.Columns.Add("Column" + i);

            // Execute each query and load into DataTables
            DataTable dt1 = ExecuteQuery(query1, sql_connect);
            DataTable dt2 = ExecuteQuery(query2, sql_connect);
            DataTable dt3 = ExecuteQuery(query3, sql_connect);

            // Assuming each DataTable has two columns, merge them into mergedTable
            foreach (DataRow row in dt1.Rows)
            {
                mergedTable.Rows.Add(row[0], row[1], DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value);
            }
            foreach (DataRow row in dt2.Rows)
            {
                mergedTable.Rows.Add(DBNull.Value, DBNull.Value, row[0], row[1], DBNull.Value, DBNull.Value);
            }
            foreach (DataRow row in dt3.Rows)
            {
                mergedTable.Rows.Add(DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, row[0], row[1]);
            }

            // Set the mergedTable as the DataSource for your DataGridView
            dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv.DataSource = mergedTable;
        }

        private static DataTable ExecuteQuery(string query, SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
    }
}
