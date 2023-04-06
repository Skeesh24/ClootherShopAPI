using ClootherShopAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClootherShopAPI.Domain.Entities
{
    public class OrderEntity : BaseEntity
    {
        public float OrderPrice { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime OrderDateTime { get; set; }
    }
}
