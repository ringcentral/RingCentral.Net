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

        /// <summary>
        /// Returns all the states of a certain country
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/dictionary/state
        /// Rate Limit Group: Light
        /// App Permission: 
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.GetStateListResponse> List(ListStatesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetStateListResponse>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns the information on a specific state.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/dictionary/state/{stateId}
        /// Rate Limit Group: Light
        /// App Permission: 
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.GetStateInfoResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.stateId == null)
            {
                throw new System.ArgumentNullException("stateId");
            }

            return await rc.Get<RingCentral.GetStateInfoResponse>(this.Path(), null, restRequestConfig);
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