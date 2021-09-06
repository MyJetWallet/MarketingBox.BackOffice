using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketingBox.Backoffice.Services.Boxes
{
    public interface IBoxItemManager
    {
        Task<List<BoxItem>> GetAll();
        Task Create(BoxItem item);
        Task Update(BoxItem item);
        Task Delete(BoxItem item);
        BoxItem Get(long id);
    }
}