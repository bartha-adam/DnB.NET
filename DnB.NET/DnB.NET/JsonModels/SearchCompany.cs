using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnB.NET.JsonModels.SearchMatch
{
    internal class TransactionDetail
    {
        [JsonProperty("ServiceTransactionID")]
        internal string ServiceTransactionID { get; set; }
        [JsonProperty("TransactionTimestamp")]
        internal DateTime TransactionTimestamp { get; set; }
    }

    internal class TransactionResult
    {
        [JsonProperty("SeverityText")]
        internal string SeverityText { get; set; }
        [JsonProperty("ResultID")]
        internal string ResultID { get; set; }
        [JsonProperty("ResultText")]
        internal string ResultText { get; set; }
    }

    internal class MatchDataCriteriaText
    {
        [JsonProperty("$")]
        internal string Value { get; set; }
    }

    internal class OrganizationName
    {
        [JsonProperty("$")]
        internal string Value { get; set; }
    }

    internal class OrganizationPrimaryName
    {
        [JsonProperty("OrganizationName")]
        internal OrganizationName OrganizationName { get; set; }
    }

    internal class StreetAddressLine
    {
        [JsonProperty("LineText")]
        internal string LineText { get; set; }
    }

    internal class PrimaryAddress
    {
        [JsonProperty("StreetAddressLine")]
        internal List<StreetAddressLine> StreetAddressLine { get; set; }
        [JsonProperty("PrimaryTownName")]
        internal string PrimaryTownName { get; set; }
        [JsonProperty("CountryISOAlpha2Code")]
        internal string CountryISOAlpha2Code { get; set; }
        [JsonProperty("PostalCode")]
        internal string PostalCode { get; set; }
        [JsonProperty("PostalCodeExtensionCode")]
        internal string PostalCodeExtensionCode { get; set; }
        [JsonProperty("TerritoryAbbreviatedName")]
        internal string TerritoryAbbreviatedName { get; set; }
        [JsonProperty("UndeliverableIndicator")]
        internal bool UndeliverableIndicator { get; set; }
    }

    internal class MailingAddress
    {
        [JsonProperty("CountryISOAlpha2Code")]
        internal string CountryISOAlpha2Code { get; set; }
        [JsonProperty("UndeliverableIndicator")]
        internal bool UndeliverableIndicator { get; set; }
    }

    internal class TelephoneNumber
    {
        [JsonProperty("TelecommunicationNumber")]
        internal string TelecommunicationNumber { get; set; }
        [JsonProperty("UnreachableIndicator")]
        internal bool UnreachableIndicator { get; set; }
    }

    internal class OperatingStatusText
    {
        [JsonProperty("$")]
        internal string Value { get; set; }
    }

    internal class MatchBasisText
    {
        [JsonProperty("$")]
        internal string Value { get; set; }
    }

    internal class MatchBasi
    {
        [JsonProperty("EndIndicator")]
        internal bool EndIndicator { get; set; }
        [JsonProperty("SubjectTypeText")]
        internal string SubjectTypeText { get; set; }
        [JsonProperty("SeniorPrincipalIndicator")]
        internal bool SeniorPrincipalIndicator { get; set; }
        [JsonProperty("MatchBasisText")]
        internal MatchBasisText MatchBasisText { get; set; }
    }

    internal class MatchGradeComponentTypeText
    {
        [JsonProperty("$")]
        internal string Value { get; set; }
    }

    internal class MatchGradeComponent
    {
        [JsonProperty("MatchGradeComponentTypeText")]
        internal MatchGradeComponentTypeText MatchGradeComponentTypeText { get; set; }
        [JsonProperty("MatchGradeComponentRating")]
        internal string MatchGradeComponentRating { get; set; }
        [JsonProperty("MatchGradeComponentScore")]
        internal double MatchGradeComponentScore { get; set; }
    }

    internal class MatchDataProfileComponentTypeText
    {
        [JsonProperty("$")]
        internal string Value { get; set; }
    }

    internal class MatchDataProfileComponent
    {
        [JsonProperty("MatchDataProfileComponentTypeText")]
        internal MatchDataProfileComponentTypeText MatchDataProfileComponentTypeText { get; set; }
        [JsonProperty("MatchDataProfileComponentValue")]
        internal string MatchDataProfileComponentValue { get; set; }
    }

    internal class MatchQualityInformation
    {
        [JsonProperty("ConfidenceCodeValue")]
        internal int ConfidenceCodeValue { get; set; }
        [JsonProperty("MatchBasis")]
        internal List<MatchBasi> MatchBasis { get; set; }
        [JsonProperty("MatchGradeText")]
        internal string MatchGradeText { get; set; }
        [JsonProperty("MatchGradeComponentCount")]
        internal int MatchGradeComponentCount { get; set; }
        [JsonProperty("MatchGradeComponent")]
        internal List<MatchGradeComponent> MatchGradeComponent { get; set; }
        [JsonProperty("MatchDataProfileText")]
        internal string MatchDataProfileText { get; set; }
        [JsonProperty("MatchDataProfileComponentCount")]
        internal int MatchDataProfileComponentCount { get; set; }
        [JsonProperty("MatchDataProfileComponent")]
        internal List<MatchDataProfileComponent> MatchDataProfileComponent { get; set; }
    }

    internal class MatchCandidate
    {
        [JsonProperty("DUNSNumber")]
        internal string DUNSNumber { get; set; }
        [JsonProperty("OrganizationPrimaryName")]
        internal OrganizationPrimaryName OrganizationPrimaryName { get; set; }
        [JsonProperty("PrimaryAddress")]
        internal PrimaryAddress PrimaryAddress { get; set; }
        [JsonProperty("MailingAddress")]
        internal MailingAddress MailingAddress { get; set; }
        [JsonProperty("TelephoneNumber")]
        internal TelephoneNumber TelephoneNumber { get; set; }
        [JsonProperty("OperatingStatusText")]
        internal OperatingStatusText OperatingStatusText { get; set; }
        [JsonProperty("StandaloneOrganizationIndicator")]
        internal bool StandaloneOrganizationIndicator { get; set; }
        [JsonProperty("MatchQualityInformation")]
        internal MatchQualityInformation MatchQualityInformation { get; set; }
        [JsonProperty("DisplaySequence")]
        internal int DisplaySequence { get; set; }
    }

    internal class MatchResponseDetail
    {
        [JsonProperty("MatchDataCriteriaText")]
        internal MatchDataCriteriaText MatchDataCriteriaText { get; set; }
        [JsonProperty("CandidateMatchedQuantity")]
        internal int CandidateMatchedQuantity { get; set; }
        [JsonProperty("MatchCandidate")]
        internal List<MatchCandidate> MatchCandidate { get; set; }
    }

    internal class MatchResponse
    {
        [JsonProperty("@ServiceVersionNumber")]
        internal string ServiceVersionNumber { get; set; }
        [JsonProperty("TransactionDetail")]
        internal TransactionDetail TransactionDetail { get; set; }
        [JsonProperty("TransactionResult")]
        internal TransactionResult TransactionResult { get; set; }
        [JsonProperty("MatchResponseDetail")]
        internal MatchResponseDetail MatchResponseDetail { get; set; }
    }

    internal class SearchMatchResponse
    {
        [JsonProperty("MatchResponse")]
        internal MatchResponse MatchResponse { get; set; }
    }
}
