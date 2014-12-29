using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DnB.NET.Helper
{
    /// <summary>
    /// Statement builder Contains all functions to build API calls and filters.
    /// </summary>
    internal sealed class StatementBuilder
    {
        /// <summary>
        /// Returns a built API string to find a company based on parameters.
        /// </summary>
        /// <param name="companyName">Company Name. (Required)</param>
        /// <param name="address1">Company full address. (Optional)</param>
        /// <param name="address2">Address. (Optional)</param>
        /// <param name="city">Company City. (Optional)</param>
        /// <param name="state">Company State. (Optional)</param>
        /// <param name="postalCode">Company Postal Code/Zipcode (Optional)</param>
        /// <param name="phone">Company phone number. (Optional)</param>
        /// <returns></returns>
        internal static string FindCompany(string companyName, string address = null, string city = null, string state = null, string postalCode = null, string phone = null)
        {
            //string url = "V6.0/organizations?SearchModeDescription=Basic&findcompany=true";
            string url = "V4.0/organizations?CountryISOAlpha2Code=US&match=true&MatchTypeText=Advanced";

            if (!String.IsNullOrEmpty(companyName))
            {
                //url += String.Format("&KeywordText={0}", companyName);
                url += String.Format("&SubjectName={0}", companyName);
            }
            if (!String.IsNullOrEmpty(address))
                url += String.Format("&StreetAddressLine-n={0}", address);
            if (!String.IsNullOrEmpty(city))
                url += String.Format("&PrimaryTownName-n={0}", city);
            if (!String.IsNullOrEmpty(state))
                url += String.Format("&TerritoryName-n={0}", state);
            if (!String.IsNullOrEmpty(postalCode))
                url += String.Format("&PostalCode-n={0}", postalCode);
            if (!String.IsNullOrEmpty(phone))
                url += String.Format("&TelecommunicationNumber={0}", phone);

            return url;
        }
        /// <summary>
        /// Returns a built API string to find company bankruptcy information based on DUN number.
        /// </summary>
        /// <param name="dun">D-U-N number</param>
        /// <returns></returns>
        internal static string Bankruptcy(string dun)
        {
            if (String.IsNullOrEmpty(dun))
                return String.Empty;

            return String.Format("V4.0/organizations/{0}/products/PBPR_STD",dun);
        }
        /// <summary>
        /// Returns a built API string to find company Paydex Score information based on DUN number.
        /// </summary>
        /// <param name="dun"></param>
        /// <returns></returns>
        internal static string PaymentPaydex(string dun)
        {
            if (String.IsNullOrEmpty(dun))
                return String.Empty;

            return String.Format("V4.0/organizations/{0}/products/PIAP_STD", dun);
        }
        /// <summary>
        /// Returns a built API string to find a company UCC information based on DUN number.
        /// </summary>
        /// <param name="dun"></param>
        /// <returns></returns>
        internal static string UCC(string dun)
        {
            if (String.IsNullOrEmpty(dun))
                return String.Empty;

            return String.Format("V3.0/organizations/{0}/products/PUBREC_UCC", dun);
        }

        internal static string Lawsuit(string dun)
        {
            if (String.IsNullOrEmpty(dun))
                return String.Empty;

            return String.Format("V3.0/organizations/{0}/products/PUBREC_SUITS", dun);
        }

        internal static string Judgment(string dun)
        {
            if (String.IsNullOrEmpty(dun))
                return String.Empty;

            return String.Format("V3.0/organizations/{0}/products/PUBREC_JDG", dun);
        }

        internal static string TaxLiens(string dun)
        {
            if (String.IsNullOrEmpty(dun))
                return String.Empty;

            return String.Format("V3.0/organizations/{0}/products/PUBREC_LIENS", dun);
        }

        internal static string FinancialHglt(string dun)
        {
            if (String.IsNullOrEmpty(dun))
                return String.Empty;

            return String.Format("V3.0/organizations/{0}/products/FIN_HGLT", dun);
        }

        internal static string FinancialStatement(string dun)
        {
            if (String.IsNullOrEmpty(dun))
                return String.Empty;

            return String.Format("V3.0/organizations/{0}/products/FIN_ST_PLUS", dun);
        }

        internal static string CompanyProfile(string dun)
        {
            if (String.IsNullOrEmpty(dun))
                return String.Empty;

            return String.Format("V3.0/organizations/{0}/products/DCP_STD", dun);
        }

        internal static string CompanyPublicRecs(string dun)
        {
            if (String.IsNullOrEmpty(dun))
                return String.Empty;

            return String.Format("V3.0/organizations/{0}/products/PUBREC_DTLS", dun);
        }
    }
}
