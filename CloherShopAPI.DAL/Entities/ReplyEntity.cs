﻿using System.ComponentModel.DataAnnotations;

namespace ClootherShopAPI.DAL.Entities
{
    public class ReplyEntity 
    {
        [Key]
        public int Id { get; set; }
        public int ProductRate { get; set; }
        public int DeliveryRate { get; set; }
        public int ServiceRate { get; set; }
        public string Username { get; set; }
        public DateTime ReplyDateTime { get; set; }
        public string? Comment { get; set; }

        // внешний ключ продукт
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }
    }
}
