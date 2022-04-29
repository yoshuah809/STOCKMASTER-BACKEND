using STOCKMASTER.DB;
using System.Collections.Generic;
using System.Linq;

namespace STOCKMASTER.StockMaster.Core
{
    public class ProductServices : IProductServices
    {
        private DContext _context;

        public ProductServices(DContext context)
        {
            _context = context;
        }
        public Product CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return product;
        }

        public void DeleteProduct(Product Product)
        {
            _context.Products.Remove(Product);
            _context.SaveChanges();
        }

        public Product EditProduct(Product product)
        {
            var dbProduct = _context.Products.First(c => c.ProdID == product.ProdID);

            dbProduct.Name = product.Name;
            dbProduct.DateCreated = product.DateCreated;
            dbProduct.Description = product.Description;
            dbProduct.Price = product.Price;
            dbProduct.CategoryID=product.CategoryID;
            dbProduct.InStock = product.InStock;
            dbProduct.isActive=product.isActive;


            _context.SaveChanges();
            

            return dbProduct;
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProduct(int id)
        {
            return _context.Products.SingleOrDefault(c => c.ProdID == id);
        }
    }
}
