using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.Country
{
    public class Index
    {
        public string countryId;
        public Dictionary.Index parent;
        public RestClient rc;

        public Index(Dictionary.Index parent, string countryId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.countryId = countryId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && countryId != null) return $"{parent.Path()}/country/{countryId}";
            return $"{parent.Path()}/country";
        }

        /// <summary>
        ///     Returns all countries available for calling.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/country
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<CountryListDictionaryModel> List(ListCountriesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CountryListDictionaryModel>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns information on a specific country.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/country/{countryId}
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<CountryInfoDictionaryModel> Get(RestRequestConfig restRequestConfig = null)
        {
            if (countryId == null) throw new ArgumentException("Parameter cannot be null", nameof(countryId));
            return await rc.Get<CountryInfoDictionaryModel>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Country.Index Country(string countryId = null)
        {
            return new Country.Index(this, countryId);
        }
    }
}