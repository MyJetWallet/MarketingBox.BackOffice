using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketingBox.Backoffice.Services.Brands
{
    public interface IBrandItemManager
    {
        Task<List<BrandItem>> GetAll();
        Task Create(BrandItem item);
        Task Update(BrandItem item);
        Task Delete(BrandItem item);
    }
}