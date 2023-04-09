using ClootherShopAPI.DAL.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClootherShopAPI.DAL.Entities
{
    public class OrderEntity
    {
        [Key]
        public int Id { get; set; }
        public float OrderPrice { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime OrderDateTime { get; set; }
    }
}
