using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnB.NET.JsonModels.CompanyPublicRec
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

    internal class MostRecentFilingDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class LienSummary
    {
        [JsonProperty("TotalFilingCount")]
        public int TotalFilingCount { get; set; }
        [JsonProperty("MostRecentFilingDate")]
        public MostRecentFilingDate MostRecentFilingDate { get; set; }
    }

    internal class FilingTypeText
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class FilingDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class FilingStatusDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class ReceivedDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class FilingStatusText
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class RolePlayerTypeText
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
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

    internal class RolePlayerLegalJurisdictionText
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class RolePlayer
    {
        [JsonProperty("RolePlayerTypeText")]
        public RolePlayerTypeText RolePlayerTypeText { get; set; }
        [JsonProperty("RolePlayerName")]
        public string RolePlayerName { get; set; }
        [JsonProperty("RolePlayerLocation")]
        public RolePlayerLocation RolePlayerLocation { get; set; }
        [JsonProperty("RolePlayerLegalJurisdictionText")]
        public RolePlayerLegalJurisdictionText RolePlayerLegalJurisdictionText { get; set; }
    }

    internal class LastUpdateDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class VerifiedDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class Lien
    {
        [JsonProperty("FilingTypeText")]
        public FilingTypeText FilingTypeText { get; set; }
        [JsonProperty("FilingDate")]
        public FilingDate FilingDate { get; set; }
        [JsonProperty("FilingStatusDate")]
        public FilingStatusDate FilingStatusDate { get; set; }
        [JsonProperty("ReceivedDate")]
        public ReceivedDate ReceivedDate { get; set; }
        [JsonProperty("FilingStatusText")]
        public FilingStatusText FilingStatusText { get; set; }
        [JsonProperty("CourtAssignedNumber")]
        public string CourtAssignedNumber { get; set; }
        [JsonProperty("RolePlayer")]
        public IList<RolePlayer> RolePlayer { get; set; }
        [JsonProperty("LastUpdateDate")]
        public LastUpdateDate LastUpdateDate { get; set; }
        [JsonProperty("FilingMediumDescription")]
        public string FilingMediumDescription { get; set; }
        [JsonProperty("VerifiedDate")]
        public VerifiedDate VerifiedDate { get; set; }
    }

    internal class LienInformation
    {
        [JsonProperty("LienSummary")]
        public LienSummary LienSummary { get; set; }
        [JsonProperty("Lien")]
        public IList<Lien> Lien { get; set; }
    }

    internal class MostRecentFilingDate2
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class JudgmentSummary
    {
        [JsonProperty("TotalFilingCount")]
        public int TotalFilingCount { get; set; }
        [JsonProperty("MostRecentFilingDate")]
        public MostRecentFilingDate2 MostRecentFilingDate { get; set; }
    }

    internal class FilingTypeText2
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class FilingDate2
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class FilingStatusDate2
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class VerifiedDate2
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class FilingStatusText2
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class RolePlayerTypeText2
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class StreetAddressLine3
    {
        [JsonProperty("LineText")]
        public string LineText { get; set; }
    }

    internal class RolePlayerLocation2
    {
        [JsonProperty("StreetAddressLine")]
        public IList<StreetAddressLine3> StreetAddressLine { get; set; }
        [JsonProperty("PrimaryTownName")]
        public string PrimaryTownName { get; set; }
        [JsonProperty("TerritoryAbbreviatedName")]
        public string TerritoryAbbreviatedName { get; set; }
        [JsonProperty("PostalCode")]
        public string PostalCode { get; set; }
    }

    internal class RolePlayer2
    {
        [JsonProperty("RolePlayerTypeText")]
        public RolePlayerTypeText2 RolePlayerTypeText { get; set; }
        [JsonProperty("RolePlayerName")]
        public string RolePlayerName { get; set; }
        [JsonProperty("RolePlayerLocation")]
        public RolePlayerLocation2 RolePlayerLocation { get; set; }
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

    internal class TextTypeDescription
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class ContactEventText
    {
        [JsonProperty("TextTypeDescription")]
        public TextTypeDescription TextTypeDescription { get; set; }
        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    internal class ContactPositionText
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
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
        [JsonProperty("ContactJobTitle")]
        public IList<string> ContactJobTitle { get; set; }
        [JsonProperty("ContactEventText")]
        public IList<ContactEventText> ContactEventText { get; set; }
        [JsonProperty("ContactPositionText")]
        public IList<ContactPositionText> ContactPositionText { get; set; }
    }

    internal class Judgment
    {
        [JsonProperty("FilingTypeText")]
        public FilingTypeText2 FilingTypeText { get; set; }
        [JsonProperty("FilingDate")]
        public FilingDate2 FilingDate { get; set; }
        [JsonProperty("FilingStatusDate")]
        public FilingStatusDate2 FilingStatusDate { get; set; }
        [JsonProperty("VerifiedDate")]
        public VerifiedDate2 VerifiedDate { get; set; }
        [JsonProperty("FilingStatusText")]
        public FilingStatusText2 FilingStatusText { get; set; }
        [JsonProperty("CourtAssignedNumber")]
        public string CourtAssignedNumber { get; set; }
        [JsonProperty("RolePlayer")]
        public IList<RolePlayer2> RolePlayer { get; set; }
        [JsonProperty("ContactEvent")]
        public IList<ContactEvent> ContactEvent { get; set; }
        [JsonProperty("FilingMediumDescription")]
        public string FilingMediumDescription { get; set; }
    }

    internal class JudgmentInformation
    {
        [JsonProperty("JudgmentSummary")]
        public JudgmentSummary JudgmentSummary { get; set; }
        [JsonProperty("Judgment")]
        public IList<Judgment> Judgment { get; set; }
    }

    internal class LegalEvents
    {
        [JsonProperty("LiensIndicator")]
        public bool LiensIndicator { get; set; }
        [JsonProperty("JudgmentIndicator")]
        public bool JudgmentIndicator { get; set; }
        [JsonProperty("SuitsIndicator")]
        public bool SuitsIndicator { get; set; }
        [JsonProperty("SuitInformation")]
        public SuitInformation SuitInformation { get; set; }
        [JsonProperty("LienInformation")]
        public LienInformation LienInformation { get; set; }
        [JsonProperty("JudgmentInformation")]
        public JudgmentInformation JudgmentInformation { get; set; }
    }

    internal class SuitSummary
    {
        [JsonProperty("TotalFilingCount")]
        public int TotalFilingCount { get; set; }
        [JsonProperty("MostRecentFilingDate")]
        public MostRecentFilingDate MostRecentFilingDate { get; set; }
    }


    internal class SuitInformation
    {
        [JsonProperty("SuitSummary")]
        public List<SuitSummary> SuitSummary { get; set; }
        [JsonProperty("Suit")]
        public List<Suit> Suit { get; set; }
    }

    internal class Suit
    {
        [JsonProperty("FilingDate")]
        public FilingDate FilingDate { get; set; }
        [JsonProperty("FilingStatusDate")]
        public FilingStatusDate FilingStatusDate { get; set; }
        [JsonProperty("ReceivedDate")]
        public ReceivedDate ReceivedDate { get; set; }
        [JsonProperty("FilingStatusText")]
        public FilingStatusText FilingStatusText { get; set; }
        [JsonProperty("CourtAssignedNumber")]
        public string CourtAssignedNumber { get; set; }
        [JsonProperty("RolePlayer")]
        public List<RolePlayer> RolePlayer { get; set; }
        [JsonProperty("LegalEventReason")]
        public List<LegalEventReason> LegalEventReason { get; set; }
        [JsonProperty("FilingOfficeName")]
        public string FilingOfficeName { get; set; }
        [JsonProperty("FilingOfficeAddress")]
        public FilingOfficeAddress FilingOfficeAddress { get; set; }
        [JsonProperty("FilingMediumDescription")]
        public string FilingMediumDescription { get; set; }
        [JsonProperty("FilingAmount")]
        public FilingAmount FilingAmount { get; set; }
    }

    internal class FilingOfficeAddress
    {
        [JsonProperty("StreetAddressLine")]
        public List<StreetAddressLine3> StreetAddressLine { get; set; }
        [JsonProperty("PrimaryTownName")]
        public string PrimaryTownName { get; set; }
        [JsonProperty("TerritoryAbbreviatedName")]
        public string TerritoryAbbreviatedName { get; set; }
        [JsonProperty("PostalCode")]
        public string PostalCode { get; set; }
    }

    internal class FilingAmount
    {
        [JsonProperty("$")]
        public double Value { get; set; }
    }

    internal class LegalEventReason
    {
        [JsonProperty("LegalEventReasonText")]
        public LegalEventReasonText LegalEventReasonText { get; set; }
        [JsonProperty("LegalEventReasonDescription")]
        public LegalEventReasonDescription LegalEventReasonDescription { get; set; }
    }

    internal class LegalEventReasonText
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class LegalEventReasonDescription
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class MostRecentFilingDate3
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class FinancialStatementFilingSummary
    {
        [JsonProperty("TotalFilingCount")]
        public int TotalFilingCount { get; set; }
        [JsonProperty("MostRecentFilingDate")]
        public MostRecentFilingDate3 MostRecentFilingDate { get; set; }
    }

    internal class FinancingStatementFilingInformation
    {
        [JsonProperty("FinancialStatementFilingSummary")]
        public FinancialStatementFilingSummary FinancialStatementFilingSummary { get; set; }
    }

    internal class FinancingEvents
    {
        [JsonProperty("FinancingStatementFilingInformation")]
        public FinancingStatementFilingInformation FinancingStatementFilingInformation { get; set; }
        [JsonProperty("UCCFilingsIndicator")]
        public bool UCCFilingsIndicator { get; set; }
    }

    internal class Events
    {
        [JsonProperty("PublicFilingHeader")]
        public PublicFilingHeader PublicFilingHeader { get; set; }
        [JsonProperty("LegalEvents")]
        public LegalEvents LegalEvents { get; set; }
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
        public int DNBCodeValue { get; set; }
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

    internal class FiledDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class DocumentTypeText
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class DocumentFilingDetail
    {
        [JsonProperty("FiledDate")]
        public FiledDate FiledDate { get; set; }
        [JsonProperty("DocumentTypeText")]
        public DocumentTypeText DocumentTypeText { get; set; }
    }

    internal class RegisteredDetail
    {
        [JsonProperty("DocumentFilingDetails")]
        public IList<DocumentFilingDetail> DocumentFilingDetails { get; set; }
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
        [JsonProperty("RegisteredDetail")]
        public RegisteredDetail RegisteredDetail { get; set; }
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

    internal class CompanyPublicRecInformation
    {
        [JsonProperty("OrderProductResponse")]
        public OrderProductResponse OrderProductResponse { get; set; }
    }
}
