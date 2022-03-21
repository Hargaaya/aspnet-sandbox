using Microsoft.EntityFrameworkCore;
using aspnet_marketplace.Data;
using aspnet_marketplace.Models;

namespace aspnet_marketplace.Services
{
    public class AdService : IAdService
    {
        private MarketplaceContext _context;

        public AdService(MarketplaceContext context)
        {
            _context = context;
        }

        public List<Advertisement> GetAdvertisementList()
        {
            return _context.Advertisements.Include(ad => ad.Images).ToList();
        }

        public List<Advertisement> GetAdvertisements(Category category)
        {
            return _context.Advertisements.Include(ad => ad.Category).Where(ad => ad.Category == category).ToList();
        }
    }
}
