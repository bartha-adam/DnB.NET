using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnB.NET.JsonModels.FindCompany
{
   internal class TransactionDetail
    {
        [JsonProperty("ApplicationTransactionID")]
        public string ApplicationTransactionID { get; set; }
        [JsonProperty("ServiceTransactionID")]
        public string ServiceTransactionID { get; set; }
        [JsonProperty("TransactionTimestamp")]
        public DateTime TransactionTimestamp { get; set; }
    }

   internal class TransactionResult
    {
        [JsonProperty("SeverityText")]
        public string SeverityText { get; set; }
        [JsonProperty("ResultID")]
        public string ResultID { get; set; }
        [JsonProperty("ResultText")]
        public string ResultText { get; set; }
    }

   internal class OrganizationName
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class OrganizationPrimaryName
    {
        [JsonProperty("OrganizationName")]
        public OrganizationName OrganizationName { get; set; }
    }

   internal class OrganizationName2
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class TradeStyleName
    {
        [JsonProperty("OrganizationName")]
        public OrganizationName2 OrganizationName { get; set; }
    }

   internal class StreetAddressLine
    {
        [JsonProperty("LineText")]
        public string LineText { get; set; }
    }

   internal class PrimaryAddress
    {
        [JsonProperty("StreetAddressLine")]
        public List<StreetAddressLine> StreetAddressLine { get; set; }
        [JsonProperty("PrimaryTownName")]
        public string PrimaryTownName { get; set; }
        [JsonProperty("CountryISOAlpha2Code")]
        public string CountryISOAlpha2Code { get; set; }
        [JsonProperty("PostalCode")]
        public string PostalCode { get; set; }
        [JsonProperty("PostalCodeExtensionCode")]
        public string PostalCodeExtensionCode { get; set; }
        [JsonProperty("TerritoryOfficialName")]
        public string TerritoryOfficialName { get; set; }
        [JsonProperty("TerritoryAbbreviatedName")]
        public string TerritoryAbbreviatedName { get; set; }
        [JsonProperty("MetropolitanStatisticalAreaUSCensusCode")]
        public List<string> MetropolitanStatisticalAreaUSCensusCode { get; set; }
    }

   internal class TelephoneNumber
    {
        [JsonProperty("TelecommunicationNumber")]
        public string TelecommunicationNumber { get; set; }
    }

   internal class FacsimileNumber
    {
        [JsonProperty("TelecommunicationNumber")]
        public string TelecommunicationNumber { get; set; }
    }

   internal class FamilyTreeMemberRoleText
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class FamilyTreeMemberRole
    {
        [JsonProperty("FamilyTreeMemberRoleText")]
        public FamilyTreeMemberRoleText FamilyTreeMemberRoleText { get; set; }
    }

   internal class ConsolidatedEmployeeDetails
    {
        [JsonProperty("TotalEmployeeQuantity")]
        public int TotalEmployeeQuantity { get; set; }
    }

   internal class SalesRevenueAmount
    {
        [JsonProperty("@CurrencyISOAlpha3Code")]
        public string CurrencyISOAlpha3Code { get; set; }
        [JsonProperty("@UnitOfSize")]
        public string UnitOfSize { get; set; }
        [JsonProperty("$")]
        public double Value { get; set; }
    }

   internal class FindCandidate
    {
        [JsonProperty("DUNSNumber")]
        public string DUNSNumber { get; set; }
        [JsonProperty("OrganizationPrimaryName")]
        public OrganizationPrimaryName OrganizationPrimaryName { get; set; }
        [JsonProperty("TradeStyleName")]
        public List<TradeStyleName> TradeStyleName { get; set; }
        [JsonProperty("PrimaryAddress")]
        public PrimaryAddress PrimaryAddress { get; set; }
        [JsonProperty("TelephoneNumber")]
        public TelephoneNumber TelephoneNumber { get; set; }
        [JsonProperty("FacsimileNumber")]
        public FacsimileNumber FacsimileNumber { get; set; }
        [JsonProperty("FamilyTreeMemberRole")]
        public List<FamilyTreeMemberRole> FamilyTreeMemberRole { get; set; }
        [JsonProperty("StandaloneOrganizationIndicator")]
        public bool StandaloneOrganizationIndicator { get; set; }
        [JsonProperty("ConsolidatedEmployeeDetails")]
        public ConsolidatedEmployeeDetails ConsolidatedEmployeeDetails { get; set; }
        [JsonProperty("SalesRevenueAmount")]
        public SalesRevenueAmount SalesRevenueAmount { get; set; }
        [JsonProperty("DisplaySequence")]
        public int DisplaySequence { get; set; }
    }

   internal class FindCompanyResponseDetail
    {
        [JsonProperty("CandidateMatchedQuantity")]
        public int CandidateMatchedQuantity { get; set; }
        [JsonProperty("CandidateReturnedQuantity")]
        public int CandidateReturnedQuantity { get; set; }
        [JsonProperty("FindCandidate")]
        public List<FindCandidate> FindCandidate { get; set; }
    }

   internal class FindCompanyResponse
    {
        [JsonProperty("@ServiceVersionNumber")]
        public string ServiceVersionNumber { get; set; }
        [JsonProperty("TransactionDetail")]
        public TransactionDetail TransactionDetail { get; set; }
        [JsonProperty("TransactionResult")]
        public TransactionResult TransactionResult { get; set; }
        [JsonProperty("FindCompanyResponseDetail")]
        public FindCompanyResponseDetail FindCompanyResponseDetail { get; set; }
    }

   internal class FoundCompany
    {
        [JsonProperty("FindCompanyResponse")]
        public FindCompanyResponse FindCompanyResponse { get; set; }
    }
}
