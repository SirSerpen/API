﻿namespace Products.Persistence.Entities
{
    public class Producthop
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    
    }
}
