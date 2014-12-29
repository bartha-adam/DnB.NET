using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnB.NET
{
    /// <summary>
    /// Model Basic Business Information. Candidate.
    /// </summary>
    public class Candidate
    {
        public string DUN { get; set; }
        public string BusinessName { get; set; }
        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
    }
    /// <summary>
    /// Principal Officer basic Information.
    /// </summary>
    public class PrincipalOfficer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
    }
    /// <summary>
    /// D&B Profile Information.
    /// </summary>
    public class DnBProfile
    {
        public Candidate BusinessBasicInfo { get; set; }
        public List<PrincipalOfficer> PricipalOfficers { get; set; }
        public string CompanyLineBusiness { get; set; }
        public string Yearstarted { get; set; }
        public int TotalEmployees { get; set; }
        public decimal SaleRevenueAmount { get; set; }
        public int PaydexScore24 { get; set; }
        public int PaydexQrlty { get; set; }
        public string NAICS { get; set; }
        public string NIC { get; set; }

    }

}
