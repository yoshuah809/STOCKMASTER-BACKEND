

using STOCKMASTER.DB;
using System.Collections.Generic;

namespace STOCKMASTER.StockMaster.Core

{
    public interface ICategoryServices
    {
        List<Category> GetCategories();
        Category GetCategory(int id);
        Category CreateCategory(Category category);
        void DeleteCategory(Category category);

        Category EditCategory(Category category);
    }
}
