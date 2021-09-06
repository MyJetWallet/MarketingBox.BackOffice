using MarketingBox.Backoffice.Services.Partners;

namespace MarketingBox.Backoffice.Services.Campaigns
{
    public class Revenue
    {
        public decimal Amount { get; set; }

        public Currency Currency { get; set; }

        public Plan Plan { get; set; }
    }
}