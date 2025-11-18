using ProductManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ave_Datagrid
{
    public partial class LoginForm : Form
    {

        private DatabaseHelper db = new DatabaseHelper();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (db.LoginUser(username, password))
            {
                this.Hide();
                Main mainForm = new Main();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверные учетные данные!");
            }
        }

        private void btnRegisterhi_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
