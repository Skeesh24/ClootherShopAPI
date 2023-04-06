namespace ClootherShopAPI.Domain.Entities
{
    public class ClientEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Reference { get; set; }
        public string? PhoneNumber { get; set; }
        public string DeliveryAddresss { get; set; }
        public int[] OrderHistory { get; set; }
        public int[]? FavoriteProducts { get; set; } 

        // внешний ключ на заказ
        public int OrderId { get; set; }
        public List<OrderEntity> Order { get; set; }
    }
}
