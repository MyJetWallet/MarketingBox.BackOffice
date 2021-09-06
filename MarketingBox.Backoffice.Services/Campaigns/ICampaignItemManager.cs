using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketingBox.Backoffice.Services.Campaigns
{
    public interface ICampaignItemManager
    {
        Task<List<CampaignItem>> GetAll();
        Task Create(CampaignItem item);
        Task Update(CampaignItem item);
        Task Delete(CampaignItem item);
    }
}