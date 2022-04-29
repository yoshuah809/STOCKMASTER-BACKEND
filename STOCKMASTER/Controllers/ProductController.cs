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
    public class ProductController : ControllerBase
    {
        private IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        // GET: api/Product
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_productServices.GetProducts());
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "GetProduct")]
        public IActionResult GetExpense(int id)
        {
            return Ok(_productServices.GetProduct(id));
        }

        // PUT: api/Product/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        
        [HttpPut]
        public IActionResult EditProduct(Product product)
        {
            return Ok(_productServices.EditProduct(product));
        }

        // POST: api/Product
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            var newProduct = _productServices.CreateProduct(product);
            return CreatedAtRoute("GetProduct", new { newProduct.ProdID }, newProduct);
        }

        // DELETE: api/Product/5
        [HttpDelete]
        public IActionResult DeleteProduct(Product product)
        {
            _productServices.DeleteProduct(product);
            return Ok();
        }

    }
}
