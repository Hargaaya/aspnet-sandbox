using System.ComponentModel.DataAnnotations;

namespace aspnet_marketplace.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [Required]
        public string Region { get; set; }

        public Advertisement Advertisement { get; set; }
    }
}