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
    public partial class RegisterForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (db.RegisterUser(username, password))
            {
                MessageBox.Show("Регистрация успешна!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка регистрации!");
            }
        }
    }
}
