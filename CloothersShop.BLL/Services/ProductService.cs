
using AutoMapper;
using ClootherShopAPI.BLL.Model;
using ClootherShopAPI.DAL.Entities;
using ClootherShopAPI.DAL.Interfaces;
using CloothersShop.BLL.Interfaces;

namespace CloothersShop.BLL.Services;

public class ProductService : IProductService
{
    public IUnitOfWork Database { get; set; }

    public ProductService(IUnitOfWork database)
    {
        Database = database;
    }


    public void AddProduct(ProductDTO productDTO)
    {
        if (productDTO == null)
            throw new NullReferenceException();

        var product = new ProductEntity()
        {
            Availability = productDTO.Availability,
            Brand = productDTO.Brand,
            Color = productDTO.Color,
            Description = productDTO.Description,
            Material = productDTO.Material,
            Params = productDTO.Params,
            Price = productDTO.Price,
            Seasonality = productDTO.Seasonality,
            Size = productDTO.Size,
            Style = productDTO.Style,
        };

        Database.Products.Create(product);
        Database.Save();
    }

    public ProductDTO GetProduct(int? id)
    {
        if (id == null)
            throw new NullReferenceException();
        var product = Database.Products.Get(id.Value);
        if (product == null)
            throw new NullReferenceException();

        return new ProductDTO()
        {
            Brand = product.Brand,
            Availability = product.Availability,
            Color = product.Color,  
            Description = product.Description,
            Material = product.Material,
            Params = product.Params,
            Price = product.Price,
            Seasonality = product.Seasonality,
            Size = product.Size,
            Style = product.Style,
        };
    }

    public IEnumerable<ProductDTO> GetProducts()
    {
        var mapper = new MapperConfiguration(conf => conf.CreateMap<ProductDTO, ProductEntity>()).CreateMapper();
        var listForMap = Database.Products.GetAll();

        if (listForMap == null)
            throw new NullReferenceException();

        var res = mapper.Map<IEnumerable<ProductEntity>, List<ProductDTO>>(listForMap);

        if (res == null)
            throw new NullReferenceException();

        return res;
    }

    public IEnumerable<ProductDTO> GetProducts(Func<ProductEntity, Boolean> predicate)
    {
        var mapper = new MapperConfiguration(conf => conf.CreateMap<ProductDTO, ProductEntity>()).CreateMapper();
        var listForMap = Database.Products.GetAll(predicate);

        if (listForMap == null)
            throw new NullReferenceException();

        var res = mapper.Map<IEnumerable<ProductEntity>, List<ProductDTO>>(listForMap);

        if (res == null)
            throw new NullReferenceException();

        return res;
    }

    public void Dispose()
    {
        Database.Dispose();
    }

}
