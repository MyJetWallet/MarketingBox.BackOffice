using System;

namespace Backoffice.Services.Partners
{
    public class PartnerItem
    {
        public Partner Partner { get; set; }
    }

    public class Partner
    {
        public long AffiliateId { get; set; }

        public PartnerGeneralInfo GeneralInfo { get; set; }
        
    }

    public class PartnerGeneralInfo
    {
        public string Username { get; set; }
        public string Passsword { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Skype { get; set; }
        public string ZipCode { get; set; }
        public PartnerRole Role { get; set; }
        public PartnerState State { get; set; }
        public PartnerCurrency Currency { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}