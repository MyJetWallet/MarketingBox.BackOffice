using System;

namespace MarketingBox.Backoffice.Services.CampaignBoxes
{
    public class ActivityHours
    {
        public DayOfWeek Day { get; set; }
        public bool IsActive { get; set; }
        public DateTime? From { get; set; }

        public DateTime? To { get; set; }
    }
}