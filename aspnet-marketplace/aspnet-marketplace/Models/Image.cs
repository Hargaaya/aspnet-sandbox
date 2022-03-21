using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspnet_marketplace.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }

        [MaxLength(200), Required]
        public string Url { get; set; }


        public int AdvertisementId { get; set; }

        [NotMapped]
        public Advertisement Advertisement { get; set; }
    }
}
