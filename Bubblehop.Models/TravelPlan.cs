using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.Marshalling;

namespace Bubblehop.Models
{
    public class TravelPlan
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter the name of your trip")]
        [Display(Name = "Trip name")]
        public string PlanName { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        public string? Description { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required(ErrorMessage = "Please enter your destination")]
        public ICollection<Destination> Destinations { get; set; }
        public ICollection<UserTravelPlan>? UserTravelPlans { get; set; }
    }
}
