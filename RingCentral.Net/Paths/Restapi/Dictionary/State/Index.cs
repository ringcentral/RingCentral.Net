using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Dictionary.State
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Dictionary.Index parent;
        public string stateId;

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
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/dictionary/state
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.GetStateListResponse> List(RingCentral.ListStatesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetStateListResponse>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns the information on a specific state.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/dictionary/state/{stateId}
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.GetStateInfoResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (stateId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(stateId));
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