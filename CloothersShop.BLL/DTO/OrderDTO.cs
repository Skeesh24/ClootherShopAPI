using ClootherShopAPI.DAL.Enums;

namespace ClootherShopAPI.BLL.Model;

public class OrderDTO
{
    public float OrderPrice { get; set; }
    public OrderStatus OrderStatus { get; set; }
}
