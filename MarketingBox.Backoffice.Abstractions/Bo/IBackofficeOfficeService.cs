using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketingBox.Backoffice.Abstractions.Bo
{
    public interface IBackofficeOfficeService
    {
        Task<IEnumerable<IOffice>> GetAsync();
        ValueTask InsertOrReplaceAsync(IOffice model);
    }
}