using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Data;
using WinFormsApp1.Helper;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txbx_email.Text;
            string password = txbx_password.Text;

           List<User> users =  ApplicationDbContext.Users;

            bool isFound = false;
            foreach (User user in users)
            {
                if(user.Email == email && user.Password == password)
                {
                    Session.User = user;
                    isFound = true;
                    break;
                }
              
            }

            if (!isFound)
            {
                MessageBox.Show("Istifadəçi adı və ya şifrə yanlışdır.");
            }
            else
            {
                AdminForm adminForm = new AdminForm();
                Session.MainForm = this;
                this.Hide();
                adminForm.Show();
            }

        }
    }
}
