using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BubblehopWeb.Models
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string LocationName { get; set; }

        public DateTime ArrivalDate { get; set; }

        public string? Activity { get; set; }

        public int TravelPlanId { get; set; }
        [ForeignKey("TravelPlanId")]
        public TravelPlan TravelPlan { get; set; }
    }
}
