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

        public async Task<RingCentral.GetCountryListResponse> List(ListQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GetCountryListResponse>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GetCountryListResponse> List(object queryParams)
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

    public class ListQueryParams
    {
        // Specifies whether login with the phone numbers of this country is enabled or not
        public bool? loginAllowed;

        // Indicates whether signup/billing is allowed for a country. If not specified all countries are returned (according to other filters specified if any)
        public bool? signupAllowed;

        // Specifies if RingCentral sells phone numbers of this country
        public bool? numberSelling;

        // Indicates the page number to retrieve. Only positive number values are accepted
        public long? page;

        // Indicates the page size (number of items)
        public long? perPage;

        // Specifies if free phone line for softphone is available for a country or not
        public bool? freeSoftphoneLine;
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