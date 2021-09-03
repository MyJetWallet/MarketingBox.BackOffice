using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MarketingBox.Backoffice.Services.Brands
{
    public class BrandItemManager : IBrandItemManager
    {
        private readonly ILogger<BrandItemManager> _logger;
        private static readonly ConcurrentBag<BrandItem> _brands = new ConcurrentBag<BrandItem>()
        {
            new BrandItem()
            {
                Brand = new Brand()
                {
                    Name = "HandelPro",
                    Id = 1
                }
            }
        };

        public BrandItemManager(ILogger<BrandItemManager> logger)
        {
            _logger = logger;
        }

        public Task<List<BrandItem>> GetAll()
        {
            return Task.FromResult(_brands.ToList());
        }

        public async Task Create(BrandItem item)
        {
        }

        public async Task Update(BrandItem item)
        {
        }

        public async Task Delete(BrandItem item)
        {
        }
    }
}