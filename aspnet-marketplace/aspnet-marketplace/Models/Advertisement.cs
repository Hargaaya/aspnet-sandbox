using System.ComponentModel.DataAnnotations;

namespace aspnet_marketplace.Models
{
    public class Advertisement
    {
        [Key]
        public int AdvertisementId { get; set; }

        [MaxLength(60), Required]
        public string Title { get; set; }

        public int Price { get; set; } = 0;

        [MaxLength(1000)]
        public string Description { get; set; } = "There is no description";


        public int UserId { get; set; }
        public User User { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }

        public List<Image> Images { get; set; }

        public ICollection<Tag> Tags { get; set; }

    }
}
