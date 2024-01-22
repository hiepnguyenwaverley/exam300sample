using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Manage_CoffeeShop.Models
{
    [Table("Users")]
    public class Users
    {

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the name")]
        [StringLength(maximumLength: 25, MinimumLength = 10, ErrorMessage = "Length must be between 10 to 25")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(10, MinimumLength=8,ErrorMessage ="Password so short!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public int RoleId { get; set; }

        public virtual Roles Role { get; set; }
    


    }
}
