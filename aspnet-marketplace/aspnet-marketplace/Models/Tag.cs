using System.ComponentModel.DataAnnotations;

namespace aspnet_marketplace.Models
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }

        [MaxLength(24), Required]
        public string Name { get; set; }

        public ICollection<Advertisement> Advertisements { get; set; }
    }
}