﻿namespace Manage_CoffeeShop.Models
{
    public class OrderItems
    {
        public Guid Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}