using RegisterAndLogin.Models;
using RegisterAndLogin.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterAndLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            UserLogin userLogin = new UserLogin();
            userLogin.Username = username;
            userLogin.Password = password;

            int result = SQLProvider.Login(userLogin, out string message);

            if (result == 1)
            {
                MessageBox.Show("Dang nhap thanh cong");
            }
            else if (result == -1)
            {
                MessageBox.Show("Sai tk");
            }
            else {
                MessageBox.Show("Sai pw");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
