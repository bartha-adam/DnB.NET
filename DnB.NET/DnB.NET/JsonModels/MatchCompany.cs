using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnB.NET.JsonModels.MatchCompany
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

    internal class MatchDataCriteriaText
    {
        [JsonProperty("$")]
        public string Value { get; set; }
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
        [JsonProperty("PostalCode")]
        public string PostalCode { get; set; }
        [JsonProperty("TerritoryAbbreviatedName")]
        public string TerritoryAbbreviatedName { get; set; }
        [JsonProperty("UndeliverableIndicator")]
        public bool UndeliverableIndicator { get; set; }
    }

    internal class MailingAddress
    {
        [JsonProperty("CountryISOAlpha2Code")]
        public string CountryISOAlpha2Code { get; set; }
        [JsonProperty("UndeliverableIndicator")]
        public bool UndeliverableIndicator { get; set; }
    }

    internal class TelephoneNumber
    {
        [JsonProperty("TelecommunicationNumber")]
        public string TelecommunicationNumber { get; set; }
        [JsonProperty("UnreachableIndicator")]
        public bool UnreachableIndicator { get; set; }
    }

    internal class OperatingStatusText
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class FamilyTreeMemberRoleText
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class FamilyTreeMemberRole
    {
        [JsonProperty("FamilyTreeMemberRoleText")]
        public FamilyTreeMemberRoleText FamilyTreeMemberRoleText { get; set; }
    }

    internal class MatchGradeComponentTypeText
    {
        [JsonProperty("$")]
        public string Value { get; set; }
    }

    internal class MatchGradeComponent
    {
        [JsonProperty("MatchGradeComponentTypeText")]
        public MatchGradeComponentTypeText MatchGradeComponentTypeText { get; set; }
        [JsonProperty("MatchGradeComponentRating")]
        public string MatchGradeComponentRating { get; set; }
        [JsonProperty("MatchGradeComponentScore")]
        public int MatchGradeComponentScore { get; set; }
    }

    internal class MatchQualityInformation
    {
        [JsonProperty("ConfidenceCodeValue")]
        public int ConfidenceCodeValue { get; set; }
        [JsonProperty("MatchGradeText")]
        public string MatchGradeText { get; set; }
        [JsonProperty("MatchGradeComponentCount")]
        public int MatchGradeComponentCount { get; set; }
        [JsonProperty("MatchGradeComponent")]
        public IList<MatchGradeComponent> MatchGradeComponent { get; set; }
        [JsonProperty("MatchDataProfileComponentCount")]
        public int MatchDataProfileComponentCount { get; set; }
    }

    internal class MatchCandidate
    {
        [JsonProperty("DUNSNumber")]
        public string DUNSNumber { get; set; }
        [JsonProperty("OrganizationPrimaryName")]
        public OrganizationPrimaryName OrganizationPrimaryName { get; set; }
        [JsonProperty("PrimaryAddress")]
        public PrimaryAddress PrimaryAddress { get; set; }
        [JsonProperty("MailingAddress")]
        public MailingAddress MailingAddress { get; set; }
        [JsonProperty("TelephoneNumber")]
        public TelephoneNumber TelephoneNumber { get; set; }
        [JsonProperty("OperatingStatusText")]
        public OperatingStatusText OperatingStatusText { get; set; }
        [JsonProperty("FamilyTreeMemberRole")]
        public IList<FamilyTreeMemberRole> FamilyTreeMemberRole { get; set; }
        [JsonProperty("StandaloneOrganizationIndicator")]
        public bool StandaloneOrganizationIndicator { get; set; }
        [JsonProperty("MatchQualityInformation")]
        public MatchQualityInformation MatchQualityInformation { get; set; }
        [JsonProperty("DisplaySequence")]
        public int DisplaySequence { get; set; }
    }

    internal class MatchResponseDetail
    {
        [JsonProperty("MatchDataCriteriaText")]
        public MatchDataCriteriaText MatchDataCriteriaText { get; set; }
        [JsonProperty("CandidateMatchedQuantity")]
        public int CandidateMatchedQuantity { get; set; }
        [JsonProperty("MatchCandidate")]
        public IList<MatchCandidate> MatchCandidate { get; set; }
    }

    internal class MatchResponse
    {
        [JsonProperty("@ServiceVersionNumber")]
        public string @ServiceVersionNumber { get; set; }
        [JsonProperty("TransactionDetail")]
        public TransactionDetail TransactionDetail { get; set; }
        [JsonProperty("TransactionResult")]
        public TransactionResult TransactionResult { get; set; }
        [JsonProperty("MatchResponseDetail")]
        public MatchResponseDetail MatchResponseDetail { get; set; }
    }

    internal class MatchCompany
    {
        [JsonProperty("MatchResponse")]
        public MatchResponse MatchResponse { get; set; }
    } 

}
