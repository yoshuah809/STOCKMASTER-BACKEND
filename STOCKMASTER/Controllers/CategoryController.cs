using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using STOCKMASTER.DB;
using STOCKMASTER.StockMaster.Core;

namespace STOCKMASTER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryServices _categoryServices;

        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        // GET: api/Category
        [HttpGet]
        public ActionResult GetCategories()
        {
            return Ok(_categoryServices.GetCategories());
        }

        // GET: api/Category/5
        [HttpGet("{id}", Name = "GetCategory")]
        public IActionResult GetCategory(int id)
        {
            return Ok(_categoryServices.GetCategory(id));
        }

        // PUT: api/Category/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public IActionResult EditCategory(Category category)
        {
            return Ok(_categoryServices.EditCategory(category));
        }


        // POST: api/Category
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            var newCategory = _categoryServices.CreateCategory(category);
            return CreatedAtRoute("GetCategory", new { newCategory.CategoryID }, newCategory);
        }

        // DELETE: api/Category/5
        [HttpDelete]
        public IActionResult DeleteCategory(Category category)
        {
            _categoryServices.DeleteCategory(category);
            return Ok();
        }

    }

}
