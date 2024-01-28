using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V_Shop.Data.Product;

namespace V_Shop.Repository
{
    public interface IProductRepository
    {
        void Save(Product product);
        List<Product> GetAllProducts();
        List<Product> GetAllProductInStock();
        void DeleteProduct(int id);
        Product GetProduct(int id);
        void UpdateProduct(Product product, int id);
        void BuyProduct(int product_id, int buyQty);
    }
}
