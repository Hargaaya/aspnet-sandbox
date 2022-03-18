using System.ComponentModel.DataAnnotations;

namespace aspnet_marketplace.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [MaxLength(30), Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        public string Phonenumber { get; set; }


        public List<Advertisement> Advertisements { get; set; }
    }
}
