using aspnet_marketplace.Models;

namespace aspnet_marketplace.Services
{
    public interface IAdService
    {
        public List<Advertisement> GetAdvertisementList();
        public List<Advertisement> GetAdvertisements(Category category);
    }
}
