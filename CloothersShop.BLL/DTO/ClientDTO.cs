namespace ClootherShopAPI.BLL.Model
{
    public class ClientDTO
    {
        public string Name { get; set; }
        public string Reference { get; set; }
        public string? PhoneNumber { get; set; }
        public string DeliveryAddresss { get; set; }
        public int[] OrderHistory { get; set; }
        public int[]? FavoriteProducts { get; set; }

        // methods ↓

    }
}
