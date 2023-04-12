
using ClootherShopAPI.BLL.Model;
using ClootherShopAPI.DAL.Entities;

namespace CloothersShop.BLL.Interfaces;

public interface IProductService
{
    void AddProduct(ProductDTO product);
    ProductDTO GetProduct(int? id);
    IEnumerable<ProductDTO> GetProducts();
    IEnumerable<ProductDTO> GetProducts(Func<ProductEntity, Boolean> predicate);
    void Dispose();
}
