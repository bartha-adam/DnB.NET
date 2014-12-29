using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnB.NET.JsonModels.CompanyProfileInformation
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

    internal class TransferDUNSNumberRegistration
    {
        [JsonProperty("TransferredFromDUNSNumber")]
        public string TransferredFromDUNSNumber { get; set; }
    }

    internal class NonMarketableReasonText
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class SubjectHeader
    {
        [JsonProperty("DUNSNumber")]
        public string DUNSNumber { get; set; }
        [JsonProperty("OrganizationSummaryText")]
        public string OrganizationSummaryText { get; set; }
        [JsonProperty("LastUpdateDate")]
        public LastUpdateDate LastUpdateDate { get; set; }
        [JsonProperty("TransferDUNSNumberRegistration")]
        public IList<TransferDUNSNumberRegistration> TransferDUNSNumberRegistration { get; set; }
        [JsonProperty("MarketabilityIndicator")]
        public bool MarketabilityIndicator { get; set; }
        [JsonProperty("NonMarketableReasonText")]
        public IList<NonMarketableReasonText> NonMarketableReasonText { get; set; }
        [JsonProperty("DUNSSelfRequestIndicator")]
        public bool DUNSSelfRequestIndicator { get; set; }
    }

    internal class TelephoneNumber
    {
        [JsonProperty("TelecommunicationNumber")]
        public string TelecommunicationNumber { get; set; }
        [JsonProperty("InternationalDialingCode")]
        public string InternationalDialingCode { get; set; }
        [JsonProperty("UnreachableIndicator")]
        public bool UnreachableIndicator { get; set; }
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

    internal class TenureTypeText
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class AddressUsageTenureDetail
    {
        [JsonProperty("TenureTypeText")]
        public TenureTypeText TenureTypeText { get; set; }
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
        [JsonProperty("AddressUsageTenureDetail")]
        public IList<AddressUsageTenureDetail> AddressUsageTenureDetail { get; set; }
        [JsonProperty("CountyOfficialName")]
        public string CountyOfficialName { get; set; }
        [JsonProperty("TerritoryOfficialName")]
        public string TerritoryOfficialName { get; set; }
        [JsonProperty("CountryGroupName")]
        public string CountryGroupName { get; set; }
        [JsonProperty("UndeliverableIndicator")]
        public bool UndeliverableIndicator { get; set; }
        [JsonProperty("RegisteredAddressIndicator")]
        public bool RegisteredAddressIndicator { get; set; }
        [JsonProperty("ResidentialAddressIndicator")]
        public bool ResidentialAddressIndicator { get; set; }
    }

    internal class Location
    {
        [JsonProperty("PrimaryAddress")]
        public IList<PrimaryAddress> PrimaryAddress { get; set; }
    }

    internal class FinancialStatementToDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class StatementHeaderDetails
    {
        [JsonProperty("FinancialStatementToDate")]
        public FinancialStatementToDate FinancialStatementToDate { get; set; }
    }

    internal class SalesRevenueAmount
    {
        [JsonProperty("@CurrencyISOAlpha3Code")]
        public string CurrencyISOAlpha3Code { get; set; }
        [JsonProperty("@UnitOfSize")]
        public string UnitOfSize { get; set; }
        [JsonProperty("$")]
        public int Value { get; set; }
    }

    internal class KeyFinancialFiguresOverview
    {
        [JsonProperty("StatementHeaderDetails")]
        public StatementHeaderDetails StatementHeaderDetails { get; set; }
        [JsonProperty("SalesRevenueAmount")]
        public IList<SalesRevenueAmount> SalesRevenueAmount { get; set; }
    }

    internal class Financial
    {
        [JsonProperty("KeyFinancialFiguresOverview")]
        public IList<KeyFinancialFiguresOverview> KeyFinancialFiguresOverview { get; set; }
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

    internal class ControlOwnershipDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class ControlOwnershipTypeText
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
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
        [JsonProperty("ControlOwnershipDate")]
        public ControlOwnershipDate ControlOwnershipDate { get; set; }
        [JsonProperty("ControlOwnershipTypeText")]
        public ControlOwnershipTypeText ControlOwnershipTypeText { get; set; }
        [JsonProperty("OperatingStatusText")]
        public OperatingStatusText OperatingStatusText { get; set; }
        [JsonProperty("OrganizationStartYear")]
        public string OrganizationStartYear { get; set; }
    }

    internal class StreetAddressLine2
    {
        [JsonProperty("LineText")]
        public string LineText { get; set; }
    }

    internal class PrimaryAddress2
    {
        [JsonProperty("StreetAddressLine")]
        public IList<StreetAddressLine2> StreetAddressLine { get; set; }
        [JsonProperty("PrimaryTownName")]
        public string PrimaryTownName { get; set; }
        [JsonProperty("PostalCode")]
        public string PostalCode { get; set; }
    }

    internal class RegistrationLocation
    {
        [JsonProperty("PrimaryAddress")]
        public IList<PrimaryAddress2> PrimaryAddress { get; set; }
    }

    internal class StartDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class OrganizationIdentificationNumberDetail
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("@TypeText")]
        public string TypeText { get; set; }
        [JsonProperty("OrganizationIdentificationNumber")]
        public string OrganizationIdentificationNumber { get; set; }
        [JsonProperty("RegistrationLocation")]
        public RegistrationLocation RegistrationLocation { get; set; }
        [JsonProperty("RegistrationIssuerName")]
        public string RegistrationIssuerName { get; set; }
        [JsonProperty("StartDate")]
        public StartDate StartDate { get; set; }
        [JsonProperty("RegistrationIssuerDUNSNumber")]
        public string RegistrationIssuerDUNSNumber { get; set; }
        [JsonProperty("AssignmentMethodText")]
        public string AssignmentMethodText { get; set; }
        [JsonProperty("DisplaySequence")]
        public int DisplaySequence { get; set; }
        [JsonProperty("FilingOrganizationName")]
        public string FilingOrganizationName { get; set; }
    }

    internal class RegisteredDetail
    {
        [JsonProperty("OrganizationIdentificationNumberDetail")]
        public IList<OrganizationIdentificationNumberDetail> OrganizationIdentificationNumberDetail { get; set; }
        [JsonProperty("IncorporationYear")]
        public string IncorporationYear { get; set; }
    }

    internal class IndustryCode3
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class IndustryCodeDescription
    {
        [JsonProperty("@IndustryCodeDescriptionLengthCode")]
        public int IndustryCodeDescriptionLengthCode { get; set; }
        [JsonProperty("@LanguageCode")]
        public int LanguageCode { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class IndustryCode2
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("@TypeText")]
        public string TypeText { get; set; }
        [JsonProperty("IndustryCode")]
        public IndustryCode3 IndustryCode { get; set; }
        [JsonProperty("IndustryCodeDescription")]
        public IList<IndustryCodeDescription> IndustryCodeDescription { get; set; }
        [JsonProperty("SalesPercentage")]
        public int SalesPercentage { get; set; }
        [JsonProperty("DisplaySequence")]
        public int DisplaySequence { get; set; }
    }

    internal class IndustryCode
    {
        [JsonProperty("IndustryCode")]
        public IList<IndustryCode2> IndustCode { get; set; }
    }

    internal class LineOfBusinessDescription
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class LineOfBusinessDetail
    {
        [JsonProperty("LineOfBusinessDescription")]
        public LineOfBusinessDescription LineOfBusinessDescription { get; set; }
    }

    internal class ActivitiesAndOperations
    {
        [JsonProperty("LineOfBusinessDetails")]
        public IList<LineOfBusinessDetail> LineOfBusinessDetails { get; set; }
        [JsonProperty("PrimarySICCategoryValue")]
        public string PrimarySICCategoryValue { get; set; }
    }

    internal class ReliabilityText
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class IndividualEntityEmployeeDetails
    {
        [JsonProperty("TotalEmployeeQuantity")]
        public int TotalEmployeeQuantity { get; set; }
        [JsonProperty("ReliabilityText")]
        public ReliabilityText ReliabilityText { get; set; }
    }

    internal class EmployeeBasisText
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class EmployeeCategoryDetail
    {
        [JsonProperty("EmployeeBasisText")]
        public EmployeeBasisText EmployeeBasisText { get; set; }
    }

    internal class ReliabilityText2
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class ConsolidatedEmployeeDetails
    {
        [JsonProperty("TotalEmployeeQuantity")]
        public int TotalEmployeeQuantity { get; set; }
        [JsonProperty("EmployeeCategoryDetails")]
        public IList<EmployeeCategoryDetail> EmployeeCategoryDetails { get; set; }
        [JsonProperty("ReliabilityText")]
        public ReliabilityText2 ReliabilityText { get; set; }
    }

    internal class EmployeeFigures
    {
        [JsonProperty("IndividualEntityEmployeeDetails")]
        public IndividualEntityEmployeeDetails IndividualEntityEmployeeDetails { get; set; }
        [JsonProperty("ConsolidatedEmployeeDetails")]
        public ConsolidatedEmployeeDetails ConsolidatedEmployeeDetails { get; set; }
    }

    internal class HistoryRatingText
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class Assessment
    {
        [JsonProperty("HistoryRatingText")]
        public HistoryRatingText HistoryRatingText { get; set; }
    }

    internal class PrincipalName
    {
        [JsonProperty("@type")]
        public string type { get; set; }
        [JsonProperty("FullName")]
        public string FullName { get; set; }
    }

    internal class JobTitleText
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class JobTitle
    {
        [JsonProperty("JobTitleText")]
        public JobTitleText JobTitleText { get; set; }
    }

    internal class PrincipalIdentificationNumberDetail
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("@TypeText")]
        public string TypeText { get; set; }
        [JsonProperty("PrincipalIdentificationNumber")]
        public string PrincipalIdentificationNumber { get; set; }
    }

    internal class CurrentPrincipal
    {
        [JsonProperty("PrincipalName")]
        public PrincipalName PrincipalName { get; set; }
        [JsonProperty("JobTitle")]
        public List<JobTitle> JobTitle { get; set; }
        [JsonProperty("PrincipalIdentificationNumberDetail")]
        public List<PrincipalIdentificationNumberDetail> PrincipalIdentificationNumberDetail { get; set; }
    }

    internal class PrincipalsAndManagement
    {
        [JsonProperty("CurrentPrincipal")]
        public List<CurrentPrincipal> CurrentPrincipal { get; set; }
    }

    internal class EthnicityTypeText
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class OwnershipEthnicity
    {
        [JsonProperty("EthnicityTypeText")]
        public EthnicityTypeText EthnicityTypeText { get; set; }
    }

    internal class SocioEconomicIdentification
    {
        [JsonProperty("MinorityOwnedIndicator")]
        public bool MinorityOwnedIndicator { get; set; }
        [JsonProperty("SmallBusinessIndicator")]
        public bool SmallBusinessIndicator { get; set; }
        [JsonProperty("OwnershipEthnicity")]
        public IList<OwnershipEthnicity> OwnershipEthnicity { get; set; }
    }

    internal class Organization
    {
        [JsonProperty("SubjectHeader")]
        public SubjectHeader SubjectHeader { get; set; }
        [JsonProperty("Telecommunication")]
        public Telecommunication Telecommunication { get; set; }
        [JsonProperty("Location")]
        public Location Location { get; set; }
        [JsonProperty("Financial")]
        public Financial Financial { get; set; }
        [JsonProperty("OrganizationName")]
        public OrganizationName OrganizationName { get; set; }
        [JsonProperty("OrganizationDetail")]
        public OrganizationDetail OrganizationDetail { get; set; }
        [JsonProperty("RegisteredDetail")]
        public RegisteredDetail RegisteredDetail { get; set; }
        [JsonProperty("IndustryCode")]
        public IndustryCode IndustryCode { get; set; }
        [JsonProperty("ActivitiesAndOperations")]
        public ActivitiesAndOperations ActivitiesAndOperations { get; set; }
        [JsonProperty("EmployeeFigures")]
        public EmployeeFigures EmployeeFigures { get; set; }
        [JsonProperty("Assessment")]
        public Assessment Assessment { get; set; }
        [JsonProperty("PrincipalsAndManagement")]
        public PrincipalsAndManagement PrincipalsAndManagement { get; set; }
        [JsonProperty("SocioEconomicIdentification")]
        public SocioEconomicIdentification SocioEconomicIdentification { get; set; }
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
        public string @ServiceVersionNumber { get; set; }
        [JsonProperty("TransactionDetail")]
        public TransactionDetail TransactionDetail { get; set; }
        [JsonProperty("TransactionResult")]
        public TransactionResult TransactionResult { get; set; }
        [JsonProperty("OrderProductResponseDetail")]
        public OrderProductResponseDetail OrderProductResponseDetail { get; set; }
    }

    internal class CompanyProfileInfo
    {
        [JsonProperty("OrderProductResponse")]
        public OrderProductResponse OrderProductResponse { get; set; }
    }
}
