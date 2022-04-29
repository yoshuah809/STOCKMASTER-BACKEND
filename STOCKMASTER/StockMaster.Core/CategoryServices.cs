using STOCKMASTER.DB;
using System.Collections.Generic;
using System.Linq;

namespace STOCKMASTER.StockMaster.Core
{
    public class CategoryServices : ICategoryServices
    {
        private DContext _context;

        public CategoryServices (DContext context)
        {
            _context = context;
        }
        public Category CreateCategory(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();

            return category;
        }

        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public Category EditCategory(Category category)
        {
            var dbCategory = _context.Categories.First(c => c.CategoryID == category.CategoryID);
            dbCategory.Name = category.Name;
            dbCategory.DateCreated = category.DateCreated;
            dbCategory.IsActive = category.IsActive;

            _context.SaveChanges();
            

            return dbCategory;
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.SingleOrDefault(c => c.CategoryID == id);
        }
    }
}
