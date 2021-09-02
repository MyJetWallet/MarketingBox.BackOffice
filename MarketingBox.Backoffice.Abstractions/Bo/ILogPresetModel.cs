using System.Collections.Generic;
using MarketingBox.Backoffice.ReflectionSearch;

namespace MarketingBox.Backoffice.Abstractions.Bo
{
    public interface ILogPresetModel
    {
        string BoUserId { get; }
        string FilterName { get; }
        string PageName { get; }
        string Filters { get; }
        IDictionary<string, SearchFilterItem> GetFilters();
    }
}