using System.ComponentModel.DataAnnotations;

namespace Bubblehop.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        public ICollection<UserTravelPlan>? UserTravelPlans { get; set; }
    }
}
