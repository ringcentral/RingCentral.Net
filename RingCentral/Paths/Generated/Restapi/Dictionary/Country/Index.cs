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

        public class ListQueryParams
        {
            // Specifies whether login with the phone numbers of this country is enabled or not
            public string loginAllowed;

            // Indicates whether signup/billing is allowed for a country. If not specified all countries are returned (according to other filters specified if any)
            public string signupAllowed;

            // Specifies if RingCentral sells phone numbers of this country
            public string numberSelling;

            // Indicates the page number to retrieve. Only positive number values are accepted
            public string page;

            // Indicates the page size (number of items)
            public string perPage;

            // Specifies if free phone line for softphone is available for a country or not
            public string freeSoftphoneLine;
        }

        public async Task<RingCentral.GetCountryListResponse> List(ListQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GetCountryListResponse>(this.Path(false), queryParams);
        }

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