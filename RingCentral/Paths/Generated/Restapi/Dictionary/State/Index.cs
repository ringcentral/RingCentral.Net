using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.State
{
    public partial class Index
    {
        public RestClient rc;
        public string stateId;
        public Restapi.Dictionary.Index parent;

        public Index(Restapi.Dictionary.Index parent, string stateId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.stateId = stateId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && stateId != null)
            {
                return $"{parent.Path()}/state/{stateId}";
            }

            return $"{parent.Path()}/state";
        }

        public class ListQueryParams
        {
            // If set to 'True' then states for all countries are returned and `countryId` is ignored, even if specified. If the value is empty then the parameter is ignored
            public string allCountries;

            // Internal identifier of a country
            public string countryId;

            // Indicates the page number to retrieve. Only positive number values are accepted
            public string page;

            // Indicates the page size (number of items)
            public string perPage;

            // If 'True', the list of states with phone numbers available for buying is returned
            public string withPhoneNumbers;
        }

        public async Task<RingCentral.GetStateListResponse> List(ListQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GetStateListResponse>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GetStateInfoResponse> Get()
        {
            if (this.stateId == null)
            {
                throw new System.ArgumentNullException("stateId");
            }

            return await rc.Get<RingCentral.GetStateInfoResponse>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Restapi.Dictionary.State.Index State(string stateId = null)
        {
            return new Restapi.Dictionary.State.Index(this, stateId);
        }
    }
}