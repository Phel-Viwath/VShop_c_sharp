using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Shop.Data.Product
{
    public class Product
    {
        private int _id;
        private string _name;
        private string _description;
        private string _category;
        private double _price_in;
        private double _price_out;
        private int _qty;
        private byte[] _imageData;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public double PriceIn
        {
            get { return _price_in; }
            set { _price_in = value; }
        }

        public double PriceOut
        {
            get { return _price_out; }
            set { _price_out = value; }
        }

        public int Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }

        public byte[] ImageData
        {
            get { return _imageData; }
            set { _imageData = value; }
        }
    }
}
