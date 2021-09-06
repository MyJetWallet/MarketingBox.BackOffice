using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketingBox.Backoffice.Services.Brands;
using MarketingBox.Backoffice.Services.Partners;
using Microsoft.Extensions.Logging;

namespace MarketingBox.Backoffice.Services.Campaigns
{
    public class CampaignItemManager : ICampaignItemManager
    {
        private readonly ILogger<CampaignItemManager> _logger;
        private static readonly ConcurrentBag<CampaignItem> _brands = new ConcurrentBag<CampaignItem>()
        {
            new CampaignItem()
            {
                Campaign = new Campaign()
                {
                    Name = "HandelPro campaign",
                    Id = 1,
                    Brand = new Brand()
                    {
                    Id = 1,
                    Name = "HandelPro"
                    },
                    Status = CampaignStatus.Active,
                    Privacy = CampaignPrivacy.Public,
                    Payout = new Payout()
                    {
                        Amount = 0,
                        Currency = Currency.EUR,
                        Plan = Plan.CPA
                    },
                    Revenue = new Revenue()
                    {
                        Amount = 0,
                        Currency = Currency.EUR,
                        Plan = Plan.CPA
                    }
                }
            }
        };

        public CampaignItemManager(ILogger<CampaignItemManager> logger)
        {
            _logger = logger;
        }

        public Task<List<CampaignItem>> GetAll()
        {
            return Task.FromResult(_brands.ToList());
        }

        public async Task Create(CampaignItem item)
        {
        }

        public async Task Update(CampaignItem item)
        {
        }

        public async Task Delete(CampaignItem item)
        {
        }
    }
}