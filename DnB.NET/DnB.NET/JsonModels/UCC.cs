using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnB.NET.JsonModels.CompanyUCC
{
    internal class TransactionDetail
    {
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

    internal class InquiryDetail
    {
        [JsonProperty("DUNSNumber")]
        public string DUNSNumber { get; set; }
        [JsonProperty("CountryISOAlpha2Code")]
        public string CountryISOAlpha2Code { get; set; }
    }

    internal class LastUpdateDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class SubjectHeader
    {
        [JsonProperty("DUNSNumber")]
        public string DUNSNumber { get; set; }
        [JsonProperty("LastUpdateDate")]
        public LastUpdateDate LastUpdateDate { get; set; }
    }

    internal class TelephoneNumber
    {
        [JsonProperty("TelecommunicationNumber")]
        public string TelecommunicationNumber { get; set; }
        [JsonProperty("InternationalDialingCode")]
        public string InternationalDialingCode { get; set; }
    }

    internal class Telecommunication
    {
        [JsonProperty("TelephoneNumber")]
        public IList<TelephoneNumber> TelephoneNumber { get; set; }
    }

    internal class StreetAddressLine
    {
        [JsonProperty("LineText")]
        public string LineText { get; set; }
    }

    internal class PrimaryAddress
    {
        [JsonProperty("StreetAddressLine")]
        public IList<StreetAddressLine> StreetAddressLine { get; set; }
        [JsonProperty("PrimaryTownName")]
        public string PrimaryTownName { get; set; }
        [JsonProperty("CountryISOAlpha2Code")]
        public string CountryISOAlpha2Code { get; set; }
        [JsonProperty("TerritoryAbbreviatedName")]
        public string TerritoryAbbreviatedName { get; set; }
        [JsonProperty("PostalCode")]
        public string PostalCode { get; set; }
        [JsonProperty("TerritoryOfficialName")]
        public string TerritoryOfficialName { get; set; }
    }

    internal class Location
    {
        [JsonProperty("PrimaryAddress")]
        public PrimaryAddress PrimaryAddress { get; set; }
    }

    internal class PublicFilingHeader
    {
        [JsonProperty("DisclaimerText")]
        public string DisclaimerText { get; set; }
    }

    internal class FinancialStatementFilingSummary
    {
        [JsonProperty("TotalFilingCount")]
        public int TotalFilingCount { get; set; }
    }

    internal class FilingTypeText
    {
        [JsonProperty("@DNBCodeValue")]
        public int @DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Vale { get; set; }
    }

    internal class FilingDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class ReceivedDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class VerifiedDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class CollateralClassText
    {
        [JsonProperty("@DNBCodeValue")]
        public int @DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class CollateralTypeText
    {
        [JsonProperty("@DNBCodeValue")]
        public int @DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class CollateralDetail
    {
        [JsonProperty("CollateralClassText")]
        public CollateralClassText CollateralClassText { get; set; }
        [JsonProperty("CollateralTypeText")]
        public CollateralTypeText CollateralTypeText { get; set; }
    }

    internal class ContactDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class ContactName
    {
        [JsonProperty("FullName")]
        public string FullName { get; set; }
    }

    internal class ContactEventText
    {
        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    internal class ContactPositionText
    {
        [JsonProperty("@DNBCodeValue")]
        public int @DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class ContactEvent
    {
        [JsonProperty("ContactDate")]
        public ContactDate ContactDate { get; set; }
        [JsonProperty("ContactName")]
        public ContactName ContactName { get; set; }
        [JsonProperty("ContactOrganizationName")]
        public string ContactOrganizationName { get; set; }
        [JsonProperty("ContactEventText")]
        public IList<ContactEventText> ContactEventText { get; set; }
        [JsonProperty("ContactPositionText")]
        public IList<ContactPositionText> ContactPositionText { get; set; }
    }

    internal class RolePlayerTypeText
    {
        [JsonProperty("@DNBCodeValue")]
        public int @DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class StreetAddressLine2
    {
        [JsonProperty("LineText")]
        public string LineText { get; set; }
    }

    internal class RolePlayerLocation
    {
        [JsonProperty("StreetAddressLine")]
        public IList<StreetAddressLine2> StreetAddressLine { get; set; }
        [JsonProperty("PrimaryTownName")]
        public string PrimaryTownName { get; set; }
        [JsonProperty("TerritoryAbbreviatedName")]
        public string TerritoryAbbreviatedName { get; set; }
        [JsonProperty("PostalCode")]
        public string PostalCode { get; set; }
    }

    internal class RolePlayer
    {
        [JsonProperty("RolePlayerTypeText")]
        public RolePlayerTypeText RolePlayerTypeText { get; set; }
        [JsonProperty("RolePlayerName")]
        public string RolePlayerName { get; set; }
        [JsonProperty("RolePlayerLocation")]
        public RolePlayerLocation RolePlayerLocation { get; set; }
    }

    internal class FilingExpirationDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class FinancialStatementFiling
    {
        [JsonProperty("FilingTypeText")]
        public FilingTypeText FilingTypeText { get; set; }
        [JsonProperty("FilingDate")]
        public FilingDate FilingDate { get; set; }
        [JsonProperty("FilingTime")]
        public DateTime FilingTime { get; set; }
        [JsonProperty("ReceivedDate")]
        public ReceivedDate ReceivedDate { get; set; }
        [JsonProperty("VerifiedDate")]
        public VerifiedDate VerifiedDate { get; set; }
        [JsonProperty("FilingReferenceNumber")]
        public string FilingReferenceNumber { get; set; }
        [JsonProperty("CollateralDetail")]
        public IList<CollateralDetail> CollateralDetail { get; set; }
        [JsonProperty("ContactEvent")]
        public IList<ContactEvent> ContactEvent { get; set; }
        [JsonProperty("RolePlayer")]
        public IList<RolePlayer> RolePlayer { get; set; }
        [JsonProperty("FilingExpirationDate")]
        public FilingExpirationDate FilingExpirationDate { get; set; }
        [JsonProperty("FilingPageQuantity")]
        public int? FilingPageQuantity { get; set; }
    }

    internal class FinancingStatementFilingInformation
    {
        [JsonProperty("FinancialStatementFilingSummary")]
        public FinancialStatementFilingSummary FinancialStatementFilingSummary { get; set; }
        [JsonProperty("FinancialStatementFiling")]
        public IList<FinancialStatementFiling> FinancialStatementFiling { get; set; }
    }

    internal class FinancingEvents
    {
        [JsonProperty("FinancingStatementFilingInformation")]
        public FinancingStatementFilingInformation FinancingStatementFilingInformation { get; set; }
    }

    internal class Events
    {
        [JsonProperty("PublicFilingHeader")]
        public PublicFilingHeader PublicFilingHeader { get; set; }
        [JsonProperty("FinancingEvents")]
        public FinancingEvents FinancingEvents { get; set; }
    }

    internal class OrganizationName2
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class OrganizationPrimaryName
    {
        [JsonProperty("OrganizationName")]
        public OrganizationName2 OrganizationName { get; set; }
    }

    internal class OrganizationName
    {
        [JsonProperty("OrganizationPrimaryName")]
        public OrganizationPrimaryName OrganizationPrimaryName { get; set; }
    }

    internal class FamilyTreeMemberRoleText
    {
        [JsonProperty("@DNBCodeValue")]
        public int @DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class FamilyTreeMemberRole
    {
        [JsonProperty("FamilyTreeMemberRoleText")]
        public FamilyTreeMemberRoleText FamilyTreeMemberRoleText { get; set; }
    }

    internal class OrganizationDetail
    {
        [JsonProperty("FamilyTreeMemberRole")]
        public IList<FamilyTreeMemberRole> FamilyTreeMemberRole { get; set; }
    }

    internal class Organization
    {
        [JsonProperty("SubjectHeader")]
        public SubjectHeader SubjectHeader { get; set; }
        [JsonProperty("Telecommunication")]
        public Telecommunication Telecommunication { get; set; }
        [JsonProperty("Location")]
        public Location Location { get; set; }
        [JsonProperty("Events")]
        public Events Events { get; set; }
        [JsonProperty("OrganizationName")]
        public OrganizationName OrganizationName { get; set; }
        [JsonProperty("OrganizationDetail")]
        public OrganizationDetail OrganizationDetail { get; set; }
    }

    internal class Product
    {
        [JsonProperty("DNBProductID")]
        public string DNBProductID { get; set; }
        [JsonProperty("Organization")]
        public Organization Organization { get; set; }
    }

    internal class OrderProductResponseDetail
    {
        [JsonProperty("InquiryDetail")]
        public InquiryDetail InquiryDetail { get; set; }
        [JsonProperty("Product")]
        public Product Product { get; set; }
    }

    internal class OrderProductResponse
    {
        [JsonProperty("@ServiceVersionNumber")]
        public string ServiceVersionNumber { get; set; }
        [JsonProperty("TransactionDetail")]
        public TransactionDetail TransactionDetail { get; set; }
        [JsonProperty("TransactionResult")]
        public TransactionResult TransactionResult { get; set; }
        [JsonProperty("OrderProductResponseDetail")]
        public OrderProductResponseDetail OrderProductResponseDetail { get; set; }
    }

    internal class CompanyUCCInformation
    {
        [JsonProperty("OrderProductResponse")]
        public OrderProductResponse OrderProductResponse { get; set; }
    }
}
