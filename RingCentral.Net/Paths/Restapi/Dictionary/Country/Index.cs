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
        /// Operation: Get Country List
        /// Http Get /restapi/v1.0/dictionary/country
        /// </summary>
        public async Task<RingCentral.GetCountryListResponse> List(ListCountriesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GetCountryListResponse>(this.Path(false), queryParams);
        }

        /// <summary>
        /// Operation: Get Country
        /// Http Get /restapi/v1.0/dictionary/country/{countryId}
        /// </summary>
        public async Task<RingCentral.GetCountryInfoDictionaryResponse> Get()
        {
            if (this.countryId == null)
            {
                throw new System.ArgumentNullException("countryId");
            }

            return await rc.Get<RingCentral.GetCountryInfoDictionaryResponse>(this.Path());
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