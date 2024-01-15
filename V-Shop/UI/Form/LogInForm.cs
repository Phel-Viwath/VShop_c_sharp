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
    public partial class LogInForm : Form
    {
        private DatabaseHelper dbHelper;
        private UserRepository repository;

        public LogInForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            repository = new UserRepository();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbSignUP_Click(object sender, EventArgs e)
        {
            this.Hide();    
            var form = new SignUpForm();
            form.ShowDialog();
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose ();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                string role;
                int id;

                if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Field will be not empty!");
                    return;
                }

                if (!repository.LogIn(email, password, out role, out id)) 
                    MessageBox.Show("Invalid username or password. Please try again.");
                else
                {
                    AccountType.id = id;
                    if (role == "admin")
                    {
                        AccountType.type = "A";
                    }
                    else if (role == "user")
                    {
                        AccountType.type= "U";
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

        

        private void btCencel_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtEmail.Focus();
        }
    }
}
