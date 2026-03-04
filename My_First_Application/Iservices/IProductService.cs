using My_First_Application.Models.DTO;

namespace My_First_Application.Iservices
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetAllProduct();
        ProductDTO? GetProductByID(int id);
        ProductDTO CreateProduct(ProductCreateDTO prodCreateDTO);
        bool UpdateProduct(int id, ProductUpdateDTO prodUndateDTO);
        bool DeleteProduct(int id);
    }
}
