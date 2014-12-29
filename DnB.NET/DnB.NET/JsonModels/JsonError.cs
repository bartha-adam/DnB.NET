using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnB.NET.JsonModels.JsonError
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

    internal class ResultMessage
    {
        [JsonProperty("ResultDescription")]
        public string ResultDescription { get; set; }
    }

    internal class TransactionResult
    {
        [JsonProperty("SeverityText")]
        public string SeverityText { get; set; }
        [JsonProperty("ResultID")]
        public string ResultID { get; set; }
        [JsonProperty("ResultText")]
        public string ResultText { get; set; }
        [JsonProperty("ResultMessage")]
        public IList<ResultMessage> ResultMessage { get; set; }
    }

    internal class MatchResponse
    {
        [JsonProperty("@ServiceVersionNumber")]
        public string ServiceVersionNumber { get; set; }
        [JsonProperty("TransactionDetail")]
        public TransactionDetail TransactionDetail { get; set; }
        [JsonProperty("TransactionResult")]
        public TransactionResult TransactionResult { get; set; }
    }

    internal class ErrorAPICall
    {
        [JsonProperty("MatchResponse")]
        public MatchResponse MatchResponse { get; set; }
    }
}
