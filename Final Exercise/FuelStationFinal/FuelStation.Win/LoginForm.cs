using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUsername.Text;
            password = txtPassword.Text;
            //txtPassword.PasswordChar = '•';
            
            if (username =="" && password == "")
            {
                MessageBox.Show("Username and Password fiels are empty","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if(username =="manager"&&password == "manager")
            {
                MessageBox.Show("Login Successfull");
                MainForm form = new MainForm();
                form.ShowDialog();
                //new MainForm().Show();
                //this.Hide();
            }
            else if (username == "cashier" && password == "cashier")
            {
                MessageBox.Show("Login Successfull");
                CustomerListForm form = new CustomerListForm();
                form.ShowDialog();
            }
            else if (username == "staff" && password == "staff")
            {
                MessageBox.Show("Login Successfull");
                ItemListForm form = new ItemListForm();
                form.ShowDialog();
            }
            else if(username != "admin" || password != "admin")
            {
                MessageBox.Show("Wrong Password or Username, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
            
        }
    }
}
