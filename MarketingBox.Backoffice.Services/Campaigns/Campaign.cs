using MarketingBox.Backoffice.Services.Brands;

namespace MarketingBox.Backoffice.Services.Campaigns
{
    public class Campaign
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public Brand Brand { get; set; }

        public Payout Payout { get; set; }

        public Revenue Revenue { get; set; }

        public CampaignStatus Status { get; set; }

        public CampaignPrivacy Privacy { get; set; }
    }
}