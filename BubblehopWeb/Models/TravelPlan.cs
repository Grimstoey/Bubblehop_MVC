using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BubblehopWeb.Models
{
    public class TravelPlan
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string PlanName { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string? Description { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public ICollection<Destination> Destinations { get; set; }
        public ICollection<UserTravelPlan>? UserTravelPlans { get; set; }
    }
}
