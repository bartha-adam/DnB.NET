using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnB.NET.JsonModels.FinancialInformation
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
        public IList<PrimaryAddress> PrimaryAddress { get; set; }
    }

   internal class FinancialStatementToDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class FinancialStatementFromDate
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class UnitOfSizeText
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class InformationScopeText
    {
        [JsonProperty("@DNBCodeValue")]
        public int @DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class ReliabilityText
    {
        [JsonProperty("@DNBCodeValue")]
        public int @DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class StatementHeaderDetails
    {
        [JsonProperty("FinancialStatementToDate")]
        public FinancialStatementToDate FinancialStatementToDate { get; set; }
        [JsonProperty("CurrencyISOAlpha3Code")]
        public string CurrencyISOAlpha3Code { get; set; }
        [JsonProperty("FiscalIndicator")]
        public bool FiscalIndicator { get; set; }
        [JsonProperty("FinancialStatementFromDate")]
        public FinancialStatementFromDate FinancialStatementFromDate { get; set; }
        [JsonProperty("UnitOfSizeText")]
        public UnitOfSizeText UnitOfSizeText { get; set; }
        [JsonProperty("InformationScopeText")]
        public InformationScopeText InformationScopeText { get; set; }
        [JsonProperty("ReliabilityText")]
        public ReliabilityText ReliabilityText { get; set; }
        [JsonProperty("FinancialPeriodDuration")]
        public string FinancialPeriodDuration { get; set; }
    }

   internal class ItemDescriptionText
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class ItemAmount
    {
        [JsonProperty("$")]
        public int Value { get; set; }
    }

   internal class StatementItem
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("ItemDescriptionText")]
        public ItemDescriptionText ItemDescriptionText { get; set; }
        [JsonProperty("ItemAmount")]
        public ItemAmount ItemAmount { get; set; }
    }

   internal class CurrentAssets
    {
        [JsonProperty("StatementItem")]
        public IList<StatementItem> StatementItem { get; set; }
    }

   internal class TotalCurrentAssetsAmount
    {
        [JsonProperty("@DNBCodeValue")]
        public int @DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public int Value { get; set; }
    }

   internal class ItemDescriptionText2
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class ItemAmount2
    {
        [JsonProperty("$")]
        public int Value { get; set; }
    }

   internal class StatementItem2
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("ItemDescriptionText")]
        public ItemDescriptionText2 ItemDescriptionText { get; set; }
        [JsonProperty("ItemAmount")]
        public ItemAmount2 ItemAmount { get; set; }
    }

   internal class LongTermAssets
    {
        [JsonProperty("StatementItem")]
        public IList<StatementItem2> StatementItem { get; set; }
    }

   internal class Assets
    {
        [JsonProperty("CurrentAssets")]
        public CurrentAssets CurrentAssets { get; set; }
        [JsonProperty("TotalCurrentAssetsAmount")]
        public TotalCurrentAssetsAmount TotalCurrentAssetsAmount { get; set; }
        [JsonProperty("LongTermAssets")]
        public LongTermAssets LongTermAssets { get; set; }
    }

   internal class TotalAssetsAmount
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public int Value { get; set; }
    }

   internal class ItemDescriptionText3
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class ItemAmount3
    {
        [JsonProperty("$")]
        public double Value { get; set; }
    }

   internal class StatementItem3
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("ItemDescriptionText")]
        public ItemDescriptionText3 ItemDescriptionText { get; set; }
        [JsonProperty("ItemAmount")]
        public ItemAmount3 ItemAmount { get; set; }
    }

   internal class CurrentLiabilities
    {
        [JsonProperty("StatementItem")]
        public IList<StatementItem3> StatementItem { get; set; }
    }

   internal class TotalCurrentLiabilitiesAmount
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public double Value { get; set; }
    }

   internal class ItemDescriptionText4
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class ItemAmount4
    {
        [JsonProperty("$")]
        public double Value { get; set; }
    }

   internal class StatementItem4
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("ItemDescriptionText")]
        public ItemDescriptionText4 ItemDescriptionText { get; set; }
        [JsonProperty("ItemAmount")]
        public ItemAmount4 ItemAmount { get; set; }
    }

   internal class LongTermLiabilities
    {
        [JsonProperty("StatementItem")]
        public IList<StatementItem4> StatementItem { get; set; }
    }

   internal class TotalLongTermLiabilitiesAmount
    {
        [JsonProperty("$")]
        public int Value { get; set; }
    }

   internal class ItemDescriptionText5
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class ItemAmount5
    {
        [JsonProperty("$")]
        public double Value { get; set; }
        [JsonProperty("@CurrencyISOAlpha3Code")]
        public string CurrencyISOAlpha3Code { get; set; }
    }

   internal class StatementItem5
    {
        [JsonProperty("@DNBCodeValue")]
        public int @DNBCodeValue { get; set; }
        [JsonProperty("ItemDescriptionText")]
        public ItemDescriptionText5 ItemDescriptionText { get; set; }
        [JsonProperty("ItemAmount")]
        public ItemAmount5 ItemAmount { get; set; }
    }

   internal class Equity
    {
        [JsonProperty("StatementItem")]
        public IList<StatementItem5> StatementItem { get; set; }
    }

   internal class ItemDescriptionText6
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class ItemAmount6
    {
        [JsonProperty("$")]
        public double Value { get; set; }
    }

   internal class StatementItem6
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("ItemDescriptionText")]
        public ItemDescriptionText6 ItemDescriptionText { get; set; }
        [JsonProperty("ItemAmount")]
        public ItemAmount6 ItemAmount { get; set; }
    }

   internal class Liabilities
    {
        [JsonProperty("CurrentLiabilities")]
        public CurrentLiabilities CurrentLiabilities { get; set; }
        [JsonProperty("TotalCurrentLiabilitiesAmount")]
        public TotalCurrentLiabilitiesAmount TotalCurrentLiabilitiesAmount { get; set; }
        [JsonProperty("LongTermLiabilities")]
        public LongTermLiabilities LongTermLiabilities { get; set; }
        [JsonProperty("TotalLongTermLiabilitiesAmount")]
        public TotalLongTermLiabilitiesAmount TotalLongTermLiabilitiesAmount { get; set; }
        [JsonProperty("Equity")]
        public Equity Equity { get; set; }
        [JsonProperty("StatementItem")]
        public IList<StatementItem6> StatementItem { get; set; }
    }

   internal class TotalLiabilitiesAmount
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public int Value { get; set; }
    }

   internal class BalanceSheet
    {
        [JsonProperty("Assets")]
        public Assets Assets { get; set; }
        [JsonProperty("TotalAssetsAmount")]
        public TotalAssetsAmount TotalAssetsAmount { get; set; }
        [JsonProperty("Liabilities")]
        public Liabilities Liabilities { get; set; }
        [JsonProperty("TotalLiabilitiesAmount")]
        public TotalLiabilitiesAmount TotalLiabilitiesAmount { get; set; }
    }

   internal class ItemDescriptionText7
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class ItemAmount7
    {
        [JsonProperty("$")]
        public double Value { get; set; }
    }

   internal class StatementItem7
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("ItemDescriptionText")]
        public ItemDescriptionText7 ItemDescriptionText { get; set; }
        [JsonProperty("ItemAmount")]
        public ItemAmount7 ItemAmount { get; set; }
    }

   internal class ProfitAndLossStatement
    {
        [JsonProperty("StatementItem")]
        public IList<StatementItem7> StatementItem { get; set; }
    }

   internal class ItemDescriptionText8
    {
        [JsonProperty("@DNBCodeValue")]
        public int DNBCodeValue { get; set; }
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class FinancialRatioItem
    {
        [JsonProperty("ItemDescriptionText")]
        public ItemDescriptionText8 ItemDescriptionText { get; set; }
        [JsonProperty("ItemRatio")]
        public double ItemRatio { get; set; }
    }

   internal class FinancialRatioCategory
    {
        [JsonProperty("FinancialRatioItem")]
        public FinancialRatioItem FinancialRatioItem { get; set; }
    }

   internal class FinancialRatios
    {
        [JsonProperty("FinancialRatioCategory")]
        public IList<FinancialRatioCategory> FinancialRatioCategory { get; set; }
    }

   internal class FinancialStatement
    {
        [JsonProperty("StatementHeaderDetails")]
        public StatementHeaderDetails StatementHeaderDetails { get; set; }
        [JsonProperty("BalanceSheet")]
        public BalanceSheet BalanceSheet { get; set; }
        [JsonProperty("ProfitAndLossStatement")]
        public ProfitAndLossStatement ProfitAndLossStatement { get; set; }
        [JsonProperty("FinancialRatios")]
        public FinancialRatios FinancialRatios { get; set; }
    }

   internal class Financial
    {
        [JsonProperty("FinancialStatement")]
        public IList<FinancialStatement> FinancialStatement { get; set; }
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

   internal class ControlOwnershipTypeText
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

   internal class OrganizationDetail
    {
        [JsonProperty("FamilyTreeMemberRole")]
        public IList<FamilyTreeMemberRole> FamilyTreeMemberRole { get; set; }
        [JsonProperty("ControlOwnershipTypeText")]
        public ControlOwnershipTypeText ControlOwnershipTypeText { get; set; }
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

   internal class CompanyFinancialInformation
    {
        [JsonProperty("OrderProductResponse")]
        public OrderProductResponse OrderProductResponse { get; set; }
    }
}
