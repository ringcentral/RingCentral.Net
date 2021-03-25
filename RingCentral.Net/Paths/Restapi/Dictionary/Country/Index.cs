using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.Country
{
    public partial class Index
    {
        public RestClient rc;
        public string countryId;
        public Restapi.Dictionary.Index parent;

        public Index(Restapi.Dictionary.Index parent, string countryId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.countryId = countryId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && countryId != null)
            {
                return $"{parent.Path()}/country/{countryId}";
            }

            return $"{parent.Path()}/country";
        }

        /// <summary>
        /// Returns all the countries available for calling.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/dictionary/country
        /// Rate Limit Group: Light
        /// App Permission: 
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.GetCountryListResponse> List(ListCountriesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetCountryListResponse>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns the information on a specific country.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/dictionary/country/{countryId}
        /// Rate Limit Group: Light
        /// App Permission: 
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.GetCountryInfoDictionaryResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.countryId == null)
            {
                throw new System.ArgumentNullException("countryId");
            }

            return await rc.Get<RingCentral.GetCountryInfoDictionaryResponse>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Restapi.Dictionary.Country.Index Country(string countryId = null)
        {
            return new Restapi.Dictionary.Country.Index(this, countryId);
        }
    }
}