using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Shop.Data.User
{
    public class UserRepository
    {

        internal DatabaseHelper dbHelper = new DatabaseHelper();

        public void Register(Users user)
        {
            string firstName = user.FirstName;
            string lastName = user.LastName;
            string email = user.Email;
            string password = user.Password;

            string query = "INSERT INTO Users( firstname, lastname, email, password, role) VALUES ( @Fname, @Lname, @Email, @Password, @Role)";
            try
            {
                using(SqlConnection conn = dbHelper.OpenConnection())
                {
                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Fname", firstName);
                        cmd.Parameters.AddWithValue("@Lname", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Role", "user");
                        cmd.ExecuteNonQuery();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool LogIn(string email, string password, out string role, out int id)
        {
            id = 0;
            role = string.Empty;
            string query = $"SELECT * FROM Users WHERE email = '{email}' AND password = '{password}'";
            try
            {
                using(SqlDataReader reader = dbHelper.ExecuteReader(query))
                {
                    if(reader.HasRows)
                    {
                        reader.Read();
                        id = Convert.ToInt32(reader[0]);
                        role = Convert.ToString(reader[5]);
                        return true;
                    }else 
                        return false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public Users GetUser(int id)
        {
            Users user;
            string query = $"Select * From Users Where user_id = '{id}'";
            try
            {
                using(SqlDataReader reader = dbHelper.ExecuteReader(query))
                {
                    if (reader.Read())
                    {
                        user = new Users
                        {
                            Id = Convert.ToInt32(reader[0]),
                            FirstName = Convert.ToString(reader[1]),
                            LastName = Convert.ToString(reader[2]),
                            Email = Convert.ToString(reader[3]),
                            Password = Convert.ToString(reader[4]),    
                        };
                        return user;
                    }
                    else return null;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
