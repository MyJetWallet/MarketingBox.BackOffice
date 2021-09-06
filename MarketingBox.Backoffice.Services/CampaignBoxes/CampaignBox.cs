using System.Collections.Generic;

namespace MarketingBox.Backoffice.Services.CampaignBoxes
{
    public class CampaignBox
    {
        public long BoxId { get; set; }
        public long CampaignId { get; set; }
        public Country Country { get; set; }
        public int Priority { get; set; }
        public int Weight { get; set; }
        public CapType CapType { get; set; }

        public long DailyCapValue { get; set; }
        public ActivityHours[] ActivityHours { get; set; }
        public string Information { get; set; }
        public bool EnableTraffic { get; set; }
    }
}