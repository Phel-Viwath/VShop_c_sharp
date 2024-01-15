using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Shop.Data.Model
{
    public class Chasier
    {
        private int _cahierId;
        private string _name;
        private string _phoneNumber;
        private DateTime _hierdate;
        private bool active;

        public int CashierID
        {
            get { return _cahierId; }
            set { _cahierId = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public DateTime Hiredate
        {
            get { return _hierdate; }
            set { _hierdate = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }
    }
}
