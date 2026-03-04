using Microsoft.AspNetCore.Mvc;
using My_First_Application.Iservices;
using My_First_Application.Models.DTO;

namespace My_First_Application.Controllers
{
    [Route("api/Controller")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetAllproducts()
        {
            var result = _productService.GetAllProduct();
            return Ok(result);
        }

        [HttpPost]
        public ActionResult<ProductDTO> AddProduct(ProductCreateDTO createDTO)
        {
            var result = _productService.CreateProduct(createDTO);
            return Ok(result);
        }
    }
}
