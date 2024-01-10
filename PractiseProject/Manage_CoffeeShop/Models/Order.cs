namespace Manage_CoffeeShop.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItems> OrderItems { get; set; }
    }
}
