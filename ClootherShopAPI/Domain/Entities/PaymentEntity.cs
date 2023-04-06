using ClootherShopAPI.Domain.Enums;
using ClootherShopAPI.Domain.Entities;

namespace ClootherShopAPI.Domain.Entities
{
    public class PaymentEntity : BaseEntity
    {
        public int PaymentPrice { get; set; }   
        public string PaymentType { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime PaymentDateTime { get; set; }

        // внешний ключ на заказ
        public int OrderId { get; set; }
        public OrderEntity Order { get; set; }

        // внешний ключ на клиента
        public int ClientId { get; set; }
        public ClientEntity Client { get; set; }
    }
}
