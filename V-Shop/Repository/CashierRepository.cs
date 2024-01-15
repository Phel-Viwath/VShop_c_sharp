using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Shop.Repository
{
    public class CashierRepository
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public List<string> GetAllCashierName()
        {
            List<string> name = new List<string>();
            
            string query = "SELECT Name FROM Cashier";
            try
            {
                using (SqlDataReader reader = dbHelper.ExecuteReader(query))
                {
                    while(reader.Read())
                    {
                        string _name = reader["Name"].ToString();
                        name.Add(_name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cashier repository" + ex.Message);
            }
            return name;
        }
    }
}
