using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnB.NET.Assembler
{
    internal class Assemble
    {
        public void Build()
        {

        }
        /// <summary>
        /// Assembles a List of Candidate object from a JSON model list.
        /// </summary>
        /// <param name="list">A Json model FindCandidate list.</param>
        /// <returns>Returns a Candidate list.</returns>
        internal static List<Candidate> Build(List<JsonModels.FindCompany.FindCandidate> list)
        {
            List<Candidate> candidates = new List<Candidate>();

            foreach (var item in list)
            {
                candidates.Add(new Candidate
                {
                    DUN = item.DUNSNumber,
                    BusinessName = item.OrganizationPrimaryName.OrganizationName.Value,
                    StreetAddress = item.PrimaryAddress.StreetAddressLine == null ? "" : item.PrimaryAddress.StreetAddressLine[0].LineText,
                    City = item.PrimaryAddress.PrimaryTownName,
                    State = item.PrimaryAddress.TerritoryAbbreviatedName,
                    PostalCode = item.PrimaryAddress.PostalCode,
                    PhoneNumber = item.TelephoneNumber == null ? null : item.TelephoneNumber.TelecommunicationNumber,
                    FaxNumber = item.FacsimileNumber == null ? "" : item.FacsimileNumber.TelecommunicationNumber
                });
            }

            return candidates;
        }
        /// <summary>
        /// Assembles a List of Candidate object from a JSON model list of JsonModels.SearchMatch.MatchCandidate.
        /// </summary>
        /// <param name="list">A JSON model list of JsonModels.SearchMatch.MatchCandidate.</param>
        /// <returns>Returns a Candidate list.</returns>
        internal static List<Candidate> Build(List<JsonModels.SearchMatch.MatchCandidate> list)
        {
            List<Candidate> candidates = new List<Candidate>();

            foreach (var item in list)
            {
                candidates.Add(new Candidate
                {
                    DUN = item.DUNSNumber,
                    BusinessName = item.OrganizationPrimaryName.OrganizationName.Value,
                    StreetAddress = item.PrimaryAddress.StreetAddressLine == null ? "" : item.PrimaryAddress.StreetAddressLine[0].LineText,
                    City = item.PrimaryAddress.PrimaryTownName,
                    State = item.PrimaryAddress.TerritoryAbbreviatedName,
                    PostalCode = item.PrimaryAddress.PostalCode,
                    PhoneNumber = item.TelephoneNumber == null ? null : item.TelephoneNumber.TelecommunicationNumber
                });
            }

            return candidates;
        }
    }
}
