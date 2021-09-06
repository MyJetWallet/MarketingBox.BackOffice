using System;

namespace MarketingBox.Backoffice.Services.Partners
{
    public class PartnerItem
    {
        public Partner Partner { get; set; }
    }

    public class Partner
    {
        public long AffiliateId { get; set; }

        public PartnerGeneralInfo GeneralInfo { get; set; }

        public PartnerCompany Company { get; set; }

        public PartnerBank Bank { get; set; }

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
        public Currency Currency { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class PartnerCompany
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string RegNumber { get; set; }

        public string VatId { get; set; }
    }

    public class PartnerBank
    {
        public string BeneficiaryName { get; set; }

        public string BeneficiaryAddress { get; set; }

        public string BankName { get; set; }

        public string BankAddress { get; set; }

        public string AccountNumber { get; set; }

        public string Swift { get; set; }

        public string Iban { get; set; }
    }
}