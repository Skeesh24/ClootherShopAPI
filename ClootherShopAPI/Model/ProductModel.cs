﻿
using ClootherShopAPI.Domain.ClootherSize;

namespace ClootherShopAPI.Model;

public class ProductModel
{
    public int Price { get; set; }
    public bool Availability { get; set; }
    public Size Size { get; set; }
    public string Params { get; set; }
    public string? Description { get; set; }
    public string? Brand { get; set; }
    public string? Color { get; set; } // #253684 example
    public string? Material { get; set; }
    public string? Style { get; set; }
    public string? Seasonality { get; set; }
}
