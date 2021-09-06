using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MarketingBox.Backoffice.Services.CampaignBoxes
{
    public class CampaignBoxItemManager : ICampaignBoxItemManager
    {
        private static DateTime _from = DateTime.Today;
        private static DateTime _to = DateTime.Today + new TimeSpan(23, 59, 0);
        private readonly ILogger<CampaignBoxItemManager> _logger;
        private static readonly ConcurrentBag<CampaignBoxItem> _brands = new ConcurrentBag<CampaignBoxItem>()
        {
            new CampaignBoxItem()
            {
                CampaignBox = new CampaignBox()
                {
                    ActivityHours = new ActivityHours[]
                    {
                        new ActivityHours(){Day =DayOfWeek.Sunday, From =_from, IsActive = true, To = _to},
                        new ActivityHours(){Day =DayOfWeek.Monday, From = _from, IsActive = true, To = _to},
                        new ActivityHours(){Day =DayOfWeek.Tuesday, From = _from, IsActive = true, To = _to},
                        new ActivityHours(){Day =DayOfWeek.Wednesday, From = _from, IsActive = true, To = _to},
                        new ActivityHours(){Day =DayOfWeek.Thursday, From = _from, IsActive = true, To = _to},
                        new ActivityHours(){Day =DayOfWeek.Friday, From = _from, IsActive = true, To = _to},
                        new ActivityHours(){Day =DayOfWeek.Saturday, From = _from, IsActive = true, To = _to},
                    },
                    BoxId = 1,
                    CapType = CapType.Clicks,
                    Country = new Country("AFG", CountryManager.GetCountryName("AFG")) ,
                    EnableTraffic = true,
                    Information = "Additional info",
                    Priority = 1,
                    Weight = 1000,
                    CampaignId = 1,
                    DailyCapValue = 10_000
                }
            }
        };

        public CampaignBoxItemManager(ILogger<CampaignBoxItemManager> logger)
        {
            _logger = logger;
        }

        public Task<List<CampaignBoxItem>> GetAll()
        {
            return Task.FromResult(_brands.ToList());
        }

        public Task<List<CampaignBoxItem>> GetAllForBox(long boxId)
        {
            return Task.FromResult(_brands.ToList());
        }

        public async Task Create(CampaignBoxItem item)
        {
        }

        public async Task Update(CampaignBoxItem item)
        {
        }

        public async Task Delete(CampaignBoxItem item)
        {
        }
    }
}