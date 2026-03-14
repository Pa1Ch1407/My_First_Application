using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
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
        [HttpGet("GetProductList")]
        [HttpGet("ProductList")]
        [HttpGet("Product")]
        public ActionResult<IEnumerable<ProductDTO>> GetAllproducts()
        {
            var result = _productService.GetAllProduct();
            return Ok(result);
        }

        //[HttpPost("Createproduct")]
        //[HttpPost("NewProduct")]
        //[HttpPost("GenerateProduct")]
        [Route("createProduct")]
        [HttpPost]
        public ActionResult<ProductDTO> AddProduct(ProductCreateDTO createDTO)
        {
            var result = _productService.CreateProduct(createDTO);
            return Created();
        }
        #region Modeb binding
        //[Route("{id}")]
        //[HttpGet]
        //public string GetId(int id)
        //{
        //    return $"Result Id: {id}";
        //}

        //Model Binding From Query
        //[HttpGet("users")]
        //public IActionResult GetUsers([FromQuery] int id, [FromQuery] string name)
        //{
        //    return Ok($"id: {id}, Name: {name}");
        //}

        //Model Binding From Route
        //[HttpGet("users/{id}/{name}")]
        //public IActionResult getUserbyId([FromRoute] int id, [FromRoute] string name)
        //{
        //    return Ok($"Id is: {id}, Name: {name}");
        //}

        //Model Binding from Form
        //public class UserForm
        //{
        //    public string Name { get; set; }
        //    public IFormFile ProfileImage { get; set; }
        //}

        //[HttpPost("upload")]
        //public IActionResult UploadUser([FromForm] UserForm user)
        //{
        //    return Ok(user.Name);
        //}



        //Model binding from Body
        //[Route("createProduct")]
        //[HttpPost]
        //public ActionResult<ProductDTO> AddProduct(ProductCreateDTO createDTO)
        //{
        //    var result = _productService.CreateProduct(createDTO);
        //    return Created();
        //}
        #endregion
    }
}
