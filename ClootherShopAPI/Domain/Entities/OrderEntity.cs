using ClootherShopAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClootherShopAPI.Domain.Entities
{
    public class OrderEntity : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public float OrderPrice { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime OrderDateTime { get; set; }
    }
}
