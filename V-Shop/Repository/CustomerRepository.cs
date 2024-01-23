using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_Shop.Data.Model.Cutomers;

namespace V_Shop.Repository
{
    public class CustomerRepository
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public void SaveCustomer(Customer customer)
        {
            string query = "INSERT INTO Customer (FirstName, LastName, Email, Phone, Address)" +
                "VALUES(@fname, @lname, @email, @phone, @address)";
            try
            {
                using(SqlConnection cnn = dbHelper.OpenConnection())
                {
                    using(SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@fname", customer.FirstName);
                        cmd.Parameters.AddWithValue("@lname", customer.LastName);
                        cmd.Parameters.AddWithValue("@email", customer.Email);
                        cmd.Parameters.AddWithValue("@phone", customer.Phone);
                        cmd.Parameters.AddWithValue("@address", customer.Address);
                        cmd.ExecuteNonQuery();
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex.Message);
            }
        }

        // Get All Cutomer
        public List<Customer> GetAllCustomers()
        {
            List<Customer> list = new List<Customer>();
            string query = "SELECT * FROM Customer";

            try
            {
                using (SqlDataReader reader = dbHelper.ExecuteReader(query))
                {
                    while (reader.Read())
                    {
                        Customer customer = new Customer
                        {
                            Id = Convert.ToInt32(reader[0]),
                            FirstName = Convert.ToString(reader[1]),
                            LastName = Convert.ToString(reader[2]),
                            Email = Convert.ToString(reader[3]),
                            Phone = Convert.ToString(reader[4]),
                            Address = Convert.ToString(reader[5]),
                        };
                        list.Add(customer);
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
