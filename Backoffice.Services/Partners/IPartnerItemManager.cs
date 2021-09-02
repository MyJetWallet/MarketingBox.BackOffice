using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backoffice.Services.Partners
{
    public interface IPartnerItemManager
    {
        Task<List<PartnerItem>> GetAll();
        Task Create(PartnerItem item);
        Task Update(PartnerItem item);
        Task Delete(PartnerItem item);
    }
}