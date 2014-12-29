using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnB.NET.JsonModels.PaymentPaydexInformation
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

    internal class SubjectHeader
    {
        [JsonProperty("DUNSNumber")]
        public string DUNSNumber { get; set; }
    }

    internal class TelephoneNumber
    {
        [JsonProperty("TelecommunicationNumber")]
        public string TelecommunicationNumber { get; set; }
        [JsonProperty("InternationalDialingCode")]
        public int InternationalDialingCode { get; set; }
    }

    internal class Telecommunication
    {
        [JsonProperty("TelephoneNumber")]
        public TelephoneNumber TelephoneNumber { get; set; }
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

    internal class FinancingEvents
    {
        [JsonProperty("SecuredFilingsIndicator")]
        public bool SecuredFilingsIndicator { get; set; }
    }

    internal class Events
    {
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
        public IList<OrganizationPrimaryName> OrganizationPrimaryName { get; set; }
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

    internal class OperatingStatusText
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class OrganizationDetail
    {
        [JsonProperty("FamilyTreeMemberRole")]
        public IList<FamilyTreeMemberRole> FamilyTreeMemberRole { get; set; }
        [JsonProperty("OperatingStatusText")]
        public OperatingStatusText OperatingStatusText { get; set; }
    }

    internal class DNBStandardRating
    {
        [JsonProperty("DNBStandardRating")]
        public string DNBStandardRate { get; set; }
    }

    internal class HistoryRatingText
    {
        [JsonProperty("DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class Assessment
    {
        [JsonProperty("DNBStandardRating")]
        public DNBStandardRating DNBStandardRating { get; set; }
        [JsonProperty("HistoryRatingText")]
        public HistoryRatingText HistoryRatingText { get; set; }
    }

    internal class PaydexDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class TwentyFourMonthsPaydex
    {
        [JsonProperty("PaydexScore")]
        public int PaydexScore { get; set; }
        [JsonProperty("PaydexDate")]
        public PaydexDate PaydexDate { get; set; }
        [JsonProperty("TotalPaymentExperiencesUsedCount")]
        public int TotalPaymentExperiencesUsedCount { get; set; }
    }

    internal class CurrentPaydexScore
    {
        [JsonProperty("TwentyFourMonthsPaydex")]
        public IList<TwentyFourMonthsPaydex> TwentyFourMonthsPaydex { get; set; }
    }

    internal class PaydexDate2
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class TwentyFourMonthsPaydex2
    {
        [JsonProperty("PaydexScore")]
        public int PaydexScore { get; set; }
        [JsonProperty("PaydexDate")]
        public PaydexDate2 PaydexDate { get; set; }
    }

    internal class PaydexScoreHistory
    {
        [JsonProperty("TwentyFourMonthsPaydex")]
        public IList<TwentyFourMonthsPaydex2> TwentyFourMonthsPaydex { get; set; }
    }

    internal class HighCreditMaximumAmount
    {
        [JsonProperty("$")]
        public int Value { get; set; }
    }

    internal class AverageHighCreditAmount
    {
        [JsonProperty("$")]
        public int Value { get; set; }
    }

    internal class PaymentsWithHighCredit
    {
        [JsonProperty("HighCreditMaximumAmount")]
        public HighCreditMaximumAmount HighCreditMaximumAmount { get; set; }
        [JsonProperty("AverageHighCreditAmount")]
        public AverageHighCreditAmount AverageHighCreditAmount { get; set; }
    }

    internal class PaymentPeriodSummary
    {
        [JsonProperty("SummaryPeriod")]
        public string SummaryPeriod { get; set; }
        [JsonProperty("PaymentsWithHighCredit")]
        public PaymentsWithHighCredit PaymentsWithHighCredit { get; set; }
    }

    internal class TwentyFourMonthsDataCoveragePayments
    {
        [JsonProperty("PaymentPeriodSummary")]
        public IList<PaymentPeriodSummary> PaymentPeriodSummary { get; set; }
    }

    internal class PurchaserDerivedData
    {
        [JsonProperty("TwentyFourMonthsDataCoveragePayments")]
        public TwentyFourMonthsDataCoveragePayments TwentyFourMonthsDataCoveragePayments { get; set; }
    }

    internal class Purchaser
    {
        [JsonProperty("CurrentPaydexScore")]
        public CurrentPaydexScore CurrentPaydexScore { get; set; }
        [JsonProperty("PaydexScoreHistory")]
        public PaydexScoreHistory PaydexScoreHistory { get; set; }
        [JsonProperty("PurchaserDerivedData")]
        public IList<PurchaserDerivedData> PurchaserDerivedData { get; set; }
    }

    internal class PaydexScoreIndustryNorm
    {
        [JsonProperty("PaydexMedianQuartileScore")]
        public int PaydexMedianQuartileScore { get; set; }
    }

    internal class PaydexScoreNorms
    {
        [JsonProperty("PaydexScoreIndustryNorms")]
        public IList<PaydexScoreIndustryNorm> PaydexScoreIndustryNorms { get; set; }
    }

    internal class BusinessTrading
    {
        [JsonProperty("Purchaser")]
        public Purchaser Purchaser { get; set; }
        [JsonProperty("PaydexScoreNorms")]
        public PaydexScoreNorms PaydexScoreNorms { get; set; }
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
        [JsonProperty("Assessment")]
        public Assessment Assessment { get; set; }
        [JsonProperty("BusinessTrading")]
        public BusinessTrading BusinessTrading { get; set; }
    }

    internal class ArchiveDetail
    {
        [JsonProperty("PortfolioAssetID")]
        public int PortfolioAssetID { get; set; }
    }

    internal class Product
    {
        [JsonProperty("DNBProductID")]
        public string DNBProductID { get; set; }
        [JsonProperty("LanguageCode")]
        public int LanguageCode { get; set; }
        [JsonProperty("Organization")]
        public Organization Organization { get; set; }
        [JsonProperty("ArchiveDetail")]
        public ArchiveDetail ArchiveDetail { get; set; }
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
        public string @ServiceVersionNumber { get; set; }
        [JsonProperty("TransactionDetail")]
        public TransactionDetail TransactionDetail { get; set; }
        [JsonProperty("TransactionResult")]
        public TransactionResult TransactionResult { get; set; }
        [JsonProperty("OrderProductResponseDetail")]
        public OrderProductResponseDetail OrderProductResponseDetail { get; set; }
    }

    internal class PaymentPaydexSTDInformation
    {
        [JsonProperty("OrderProductResponse")]
        public OrderProductResponse OrderProductResponse { get; set; }
    }
}
