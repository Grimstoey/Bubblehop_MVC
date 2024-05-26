using System.ComponentModel.DataAnnotations.Schema;

namespace BubblehopWeb.Models
{
    public class UserTravelPlan
    {
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }


        public int TravelPlanId { get; set; }
        [ForeignKey("TravelPlanId")]
        public TravelPlan TravelPlan { get; set; }
    }
}
