using My_First_Application.Iservices;
using My_First_Application.Models;
using My_First_Application.Models.DTO;

namespace My_First_Application.Services
{
    public class ProductService : IProductService
    {
        private static List<Category> _categories = new()
        {
            new Category{Id = 1, Name = "Mobiles"},
            new Category{Id = 2, Name = "Furniture"},
            new Category{Id = 3, Name = "Electronics"},
            new Category{Id = 4, Name = "Clothes"},

        };
        private static List<product> _products = new()
        {
            new product{Id = 1, Name="Iphone17 Pro Max", Price= 1500.00, CategoryId= 1 },
            new product{Id = 2, Name="Iphone17", Price= 850.00, CategoryId= 1 },
            new product{Id = 3, Name="WakeFit Sofa", Price= 150.00, CategoryId= 2 },
            new product{Id = 4, Name="Lg 43'' inch tv", Price= 500.00, CategoryId= 3 },
            new product{Id = 5, Name="Panasonic Tv", Price= 600.00, CategoryId= 3 },
            new product{Id = 6, Name="levis pair", Price= 150.00, CategoryId= 4 },

        };
        public ProductDTO CreateProduct(ProductCreateDTO prodCreateDTO)
        {
            var newProduct = new product
            {
                Id = _products.Max(p=>p.Id)+1,
                Name = prodCreateDTO.Name,
                Price = prodCreateDTO.Price,
                CategoryId = _categories.FirstOrDefault(c => c.Name == prodCreateDTO.CategoryName)?.Id ?? 0,
            };
            _products.Add(newProduct);
            return new ProductDTO
            {
                Id = newProduct.Id,
                Name = newProduct.Name,
                Price = newProduct.Price,
                CategoryName = _categories.FirstOrDefault(c => c.Id == newProduct.CategoryId)?.Name ?? "UnSpecified"
            };
        }

        public bool DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDTO> GetAllProduct()
        {
            var product = _products.Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                CategoryName = _categories.FirstOrDefault(c => c.Id == p.CategoryId)?.Name ?? "Unspecified"
            });
            return product;
        }

        public ProductDTO? GetProductByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(int id, ProductUpdateDTO prodUndateDTO)
        {
            throw new NotImplementedException();
        }
    }
}
