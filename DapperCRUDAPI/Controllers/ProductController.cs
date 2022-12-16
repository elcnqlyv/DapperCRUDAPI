using DapperCRUDAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperCRUDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository productRepository;
        public ProductController() {
        productRepository= new ProductRepository();
        }
        [HttpGet]
        public IEnumerable<Product> Get() 
        {
        return productRepository.GetAll();
        }

        [HttpGet]
        public Product Get(int id)
        {
            return productRepository.GetById(id);
        }
    }
}
