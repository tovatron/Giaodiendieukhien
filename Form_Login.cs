using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giaodiendieukhien
{
    public partial class Form_Login : Form
    {
        public Point mouseLocation;
        public bool IsFormAdminActived;
        public Form_Login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void btnCloseapp_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Drag_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        TruyvanLogin truyvan = new TruyvanLogin();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if(username.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản !");
                return;
            }
            else if(password.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu !");
                return;
            }   
            else
            {
                string query = "SELECT * FROM Loginaccount WHERE Username = @Username AND Password = @Password";
                if (truyvan.Loginaccounts(query, username, password).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    string roleQuery = "SELECT Role FROM Loginaccount WHERE Username = @Username AND Password = @Password";
                    string role = truyvan.Roles(roleQuery, username, password);
                    if (role == "admin")
                    {
                        this.Hide();
                        Form_Admin formadmin = new Form_Admin();
                        IsFormAdminActived = true;
                        formadmin.lbUserAF.Text = txtUsername.Text;
                        formadmin.ShowDialog();
                        this.Close();
                    }
                    else if (role == "user")
                    {
                        this.Hide();
                        Form_User formuser = new Form_User();
                        IsFormAdminActived = false;
                        formuser.lbUserUF.Text = txtUsername.Text;
                        formuser.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }
            }
        }
    }
}
