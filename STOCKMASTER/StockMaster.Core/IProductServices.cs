using STOCKMASTER.DB;
using System.Collections.Generic;

namespace STOCKMASTER.StockMaster.Core

{
    public interface IProductServices
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        Product CreateProduct(Product product);
        void DeleteProduct(Product product);

        Product EditProduct(Product product);
    }
}
