﻿using ClootherShopAPI.DAL.Enums;

namespace ClootherShopAPI.Model;

public class OrderModel
{
    public float OrderPrice { get; set; }
    public OrderStatus OrderStatus { get; set; }
}
