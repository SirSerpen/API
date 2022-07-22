namespace Products.Persistence.Entities
{
    public class Shop
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Address { get; set; }

        public virtual ICollection<Producthop> Product { get; set; }
    }
}
