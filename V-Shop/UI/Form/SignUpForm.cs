using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_Shop.Data.User;
using V_Shop.User;

namespace V_Shop.Presentation
{
    public partial class SignUpForm : Form
    {

        private int userId;
        private UserRepository repository;

        public SignUpForm()
        {
            InitializeComponent();
            repository = new UserRepository();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lbSignUP_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm form = new LogInForm();
            form.ShowDialog();
            this.Dispose();
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Users user = new Users
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                };
                ///
                string email = user.Email;
                string password = user.Password;
                string role = user.Role;
                int id = user.Id;
                //
                repository.Register(user);
                ///
                if(!repository.LogIn(email, password, out role, out id) )
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
                else
                {
                    AccountType.id = id;
                    if (role == "admin")
                    {
                        AccountType.type = "A";
                    }
                    else if (role == "user")
                    {
                        AccountType.type = "U";
                    }
                    this.Hide();
                    var form = new MainForm(role, id);
                    form.ShowDialog();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
