using System.ComponentModel.DataAnnotations;

namespace aspnet_marketplace.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [MaxLength(30), Required]
        public string Name { get; set; }

        [MaxLength(100), Required]
        public string Description { get; set; }

        public Advertisement Advertisement { get; set; }

    }
}