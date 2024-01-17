using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manage_CoffeeShop.Models
{
    public class ProductViewModel
    {
        
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Images { get;set; }
     
        public decimal Price { get; set; }
    }
}
