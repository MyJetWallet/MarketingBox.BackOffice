using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketingBox.Backoffice.Services.Partners
{
    public interface IPartnerItemManager
    {
        Task<List<PartnerItem>> GetAll();
        Task Create(PartnerItem item);
        Task Update(PartnerItem item);
        Task Delete(PartnerItem item);
    }
}