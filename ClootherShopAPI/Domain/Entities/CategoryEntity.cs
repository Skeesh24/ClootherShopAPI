using System.ComponentModel.DataAnnotations;

namespace ClootherShopAPI.Domain.Entities
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        // внешний ключ продукт
        public int ProductId { get; set; }
        public List<ProductEntity> Product { get; set; }
    }
}
