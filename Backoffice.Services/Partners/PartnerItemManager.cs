﻿using System;
using System.Collections.Concurrent;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backoffice.Services.Partners
{
    public class PartnerItemManager : IPartnerItemManager
    {
        private readonly ILogger<PartnerItemManager> _logger;
        private static readonly ConcurrentBag<PartnerItem> _partners = new ConcurrentBag<PartnerItem>()
        {
            new PartnerItem()
            {
                Partner = new Partner()
                {
                    GeneralInfo = new PartnerGeneralInfo()
                    {
                        CreatedAt = DateTime.UtcNow,
                        Currency = PartnerCurrency.EUR,
                        Email = "some.e@simpl.net",
                        Passsword = "********",
                        Phone = "747474",
                        Role = PartnerRole.Affiliate,
                        Skype = "skype",
                        State = PartnerState.Active,
                        Username = "TestUser",
                        ZipCode = "414141"
                    },
                    AffiliateId = 1
                }
            }
        };

        public PartnerItemManager(ILogger<PartnerItemManager> logger)
        {
            _logger = logger;
        }

        public Task<List<PartnerItem>> GetAll()
        {
            return Task.FromResult(_partners.ToList());
        }

        public async Task Create(PartnerItem item)
        {
        }

        public async Task Update(PartnerItem item)
        {
        }

        public async Task Delete(PartnerItem item)
        {
        }
    }
}