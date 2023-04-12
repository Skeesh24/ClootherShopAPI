
namespace ClootherShopAPI.WEB.Model;

public class ClientViewModel
{
    public string Name { get; set; }
    public string Reference { get; set; }
    public string? PhoneNumber { get; set; }
    public string DeliveryAddresss { get; set; }
    public int[] OrderHistory { get; set; }
    public int[]? FavoriteProducts { get; set; }
}
