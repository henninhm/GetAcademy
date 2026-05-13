using Microsoft.AspNetCore.Mvc;
using Test_3.Models;

namespace Test_3.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : Controller
    {
        private readonly ProductContext _context;

        public ProductController(ProductContext context)
        {
            _context = context;
        }

        // GET: api/products
        // https://localhost:7272/api/products
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.GetAllProducts());
        }

        // GET: api/products/3
        // https://localhost:7272/api/products/3
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var products = _context.GetAllProducts();
            var product = products.FirstOrDefault(u => u.id == id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }
    }
}
