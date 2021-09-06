using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketingBox.Backoffice.Services.CampaignBoxes
{
    public interface ICampaignBoxItemManager
    {
        Task<List<CampaignBoxItem>> GetAllForBox(long boxId);
        Task Create(CampaignBoxItem item);
        Task Update(CampaignBoxItem item);
        Task Delete(CampaignBoxItem item);
    }
}