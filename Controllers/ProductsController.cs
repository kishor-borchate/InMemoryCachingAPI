using InMemoryCachingAPI.BuisnessLogic;
using InMemoryCachingAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InMemoryCachingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        } 

       [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            var products = _service.GetAllProducts();
            return Ok(products);
        }
    }
}
