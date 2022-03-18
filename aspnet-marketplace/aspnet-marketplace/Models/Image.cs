using System.ComponentModel.DataAnnotations;

namespace aspnet_marketplace.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }

        [MaxLength(200), Required]
        public string Url { get; set; }


        public int AdvertisementId { get; set; }
        public Advertisement Advertisement { get; set; }
    }
}
