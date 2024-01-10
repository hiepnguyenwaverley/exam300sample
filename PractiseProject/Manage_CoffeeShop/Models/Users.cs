using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Manage_CoffeeShop.Models
{
    [Table("Users")]
    public class Users
    {

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]                              
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        public int RoleId { get; set; }
        public virtual Roles Role { get; set; }
    


    }
}
