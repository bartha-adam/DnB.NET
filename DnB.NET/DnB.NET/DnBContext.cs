using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Configuration;
using DnB.NET.Helper;
using DnB.NET.Assembler;

namespace DnB.NET
{
    public class DnBContext
    {
        #region Fields
        /// <summary>
        /// Holds security token after success logged in.
        /// </summary>
        private string _Token = String.Empty;
        /// <summary>
        /// Local variable that holds a boolean value to check if user was authorized. 
        /// </summary>
        private bool _IsValid = false;
        /// <summary>
        /// Local variable that holds the WebRequests for D&B.
        /// </summary>
        private WebRequest _Request;
        private string _DnBBasicURL =  String.Empty;
        private string _DUNNumber = String.Empty;
        private string _ErrorMessage = String.Empty;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes DnBContext by authenticating user credentials.
        /// </summary>
        /// <param name="username">D&B username</param>
        /// <param name="password">D&B password</param>
        /// <param name="dnbBasicURL">D&B basic LIVE|Sandbox URL.</param>
        public DnBContext(string username, string password, string dnbBasicURL)
        {
            try
            {
                _Request = WebRequest.Create(new Uri(String.Format("{0}rest/Authentication", dnbBasicURL)));
                _Request.Method = "POST";
                _Request.ContentType = "application/json; charset=UTF-8";
                _Request.Headers.Add("x-dnb-user", username);
                _Request.Headers.Add("x-dnb-pwd", password);

                HttpWebResponse response = (HttpWebResponse)_Request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.NoContent)
                {
                    if (!String.IsNullOrEmpty(response.Headers["Authorization"]))
                    {
                        _Token = response.Headers["Authorization"].ToString();
                        _IsValid = true;
                        _DnBBasicURL = dnbBasicURL;
                    }
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    //TODO: Handle, Show
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var json = streamReader.ReadToEnd();
                    }
                }
                response.Close();
            }
            catch (JsonSerializationException jex)
            {
                ErrorMesage = jex.InnerException.Message;
                _IsValid = false;
            }
            catch (WebException wex)
            {
                HttpWebResponse resp = (HttpWebResponse)wex.Response;
                ErrorMesage = resp.StatusDescription;
                _IsValid = false;
            }
            catch (Exception ex)
            {
                ErrorMesage = ex.Message;
                _IsValid = false;
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the error message if call returns FALSE. It will be empty if call returns TRUE.
        /// </summary>
        public string ErrorMesage
        {
            get
            {
                return _ErrorMessage;
            }
            private set
            {
                _ErrorMessage = value;
            }
        }
        /// <summary>
        /// Gets the Authorized TOKEN after a successful logged in. Otherwise empty.
        /// </summary>
        public string LoggedToken
        {
            get
            {
                return _Token;
            }
            private set
            {
                _Token = value;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns a list of business candidates based on search key. 
        /// </summary>
        /// <param name="searchKey">search key eg. microsoft</param>
        /// <returns>Returns a list of candidates.</returns>
        public List<Candidate> SearchBusinessCandidates(string searchKey)
        {
            List<Candidate> candidates = new List<Candidate>();
            try
            {
                //Build the API  request to be send.
                _Request = WebRequest.Create(new Uri(String.Format("{0}{1}", _DnBBasicURL, StatementBuilder.FindCompany(searchKey))));
                _Request.Method = "GET";
                _Request.ContentType = "application/json; charset=UTF-8";
                _Request.Headers.Add("Authorization", _Token);
                //Call the API and get a response.
                HttpWebResponse response = (HttpWebResponse)_Request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        //Get Json
                        string json = streamReader.ReadToEnd();
                        //Deserialized Json
                        var foundCompany = JsonConvert.DeserializeObject<DnB.NET.JsonModels.SearchMatch.SearchMatchResponse>(json);
                        if (foundCompany == null)
                        {
                            _ErrorMessage = "No results found";
                            return null;
                        }

                        if (foundCompany.MatchResponse.TransactionResult.ResultText.Equals("Success"))
                        {
                            List<Candidate> results = Assemble.Build(foundCompany.MatchResponse.MatchResponseDetail.MatchCandidate);
                            if (results == null || results.Count <= 0)
                            {
                                _ErrorMessage = "No results found. Couldn't Build Object from JSON.";
                                return null;
                            }

                            candidates = results;
                        }
                        else
                        {
                            _ErrorMessage = "API Call Success. Couldn't read data.";
                            return null;
                        }
                    }
                }
                response.Close();
            }
            catch (WebException wex)
            {
                HttpWebResponse resp = (HttpWebResponse)wex.Response;
                if (resp.StatusCode == HttpStatusCode.NotFound)
                {
                    _ErrorMessage = "Entity not found";
                    return null;
                }
                else
                {
                    using (var streamReader = new StreamReader(resp.GetResponseStream()))
                    {
                        var errAPI = JsonConvert.DeserializeObject<DnB.NET.JsonModels.JsonError.ErrorAPICall>(streamReader.ReadToEnd());
                        _ErrorMessage = String.Format("API CALL ERROR: {0} - {1}", errAPI.MatchResponse.TransactionResult.ResultText, errAPI.MatchResponse.TransactionResult.ResultMessage[0].ResultDescription);
                    }
                    return null;
                }
            }
            catch (JsonSerializationException jex)
            {
                _ErrorMessage = "Json De-serialization exception.";
                return null;
            }
            catch (Exception ex)
            {
                _ErrorMessage = ex.Message;
                return null;
            }

            return candidates;
        }

        public DnBProfile GetDnBProfile(string dun)
        {
            DnBProfile dnbProfile = new DnBProfile();
            dnbProfile.BusinessBasicInfo = new Candidate();
            dnbProfile.PricipalOfficers = new List<PrincipalOfficer>();
            
            try
            {
                //Build the API  request to be send.
                _Request = WebRequest.Create(new Uri(String.Format("{0}{1}", ConfigurationManager.AppSettings["dnbBasicURL"], StatementBuilder.CompanyProfile(dun))));
                _Request.Method = "GET";
                _Request.ContentType = "application/json; charset=UTF-8";
                _Request.Headers.Add("Authorization", _Token);
                //Call the API and get a response.
                HttpWebResponse response = (HttpWebResponse)_Request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var companyProfile = JsonConvert.DeserializeObject<DnB.NET.JsonModels.CompanyProfileInformation.CompanyProfileInfo>(streamReader.ReadToEnd());
                        if (companyProfile == null)
                        {
                            _ErrorMessage = "No results found";
                            return null;
                        }
                        

                    }
                }

                response.Close();

                return dnbProfile;
            }
            catch (JsonSerializationException jex)
            {
                _ErrorMessage = "Json De-serialization exception. " + jex.Message;
                return null;
            }
            catch (WebException wex)
            {
                HttpWebResponse resp = (HttpWebResponse)wex.Response;
                _ErrorMessage = resp.StatusCode.ToString() + " " + resp.StatusDescription;
                return null;
            }
            catch (Exception ex)
            {
                _ErrorMessage = ex.Message + " | " + ex.StackTrace + " | " +ex.Source;
                return null;
            }
        }
        #endregion
    }
}
