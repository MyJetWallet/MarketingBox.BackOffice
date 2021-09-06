using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MarketingBox.Backoffice.Services.Boxes
{
    public class BoxItemManager : IBoxItemManager
    {
        private readonly ILogger<BoxItemManager> _logger;
        private static readonly ConcurrentBag<BoxItem> _items = new ConcurrentBag<BoxItem>()
        {
            new BoxItem()
            {
                Box = new Box()
                {
                    Name = "HandelPro",
                    Id = 1
                }
            }
        };

        public BoxItemManager(ILogger<BoxItemManager> logger)
        {
            _logger = logger;
        }

        public Task<List<BoxItem>> GetAll()
        {
            return Task.FromResult(_items.ToList());
        }

        public async Task Create(BoxItem item)
        {
        }

        public async Task Update(BoxItem item)
        {
        }

        public async Task Delete(BoxItem item)
        {
        }

        public BoxItem Get(long id)
        {
            return _items.First();
        }
    }
}