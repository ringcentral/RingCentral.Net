using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.State
{
    public class Index
    {
        public Dictionary.Index parent;
        public RestClient rc;
        public string stateId;

        public Index(Dictionary.Index parent, string stateId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.stateId = stateId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && stateId != null) return $"{parent.Path()}/state/{stateId}";

            return $"{parent.Path()}/state";
        }

        /// <summary>
        ///     Returns all the states of a certain country
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/state
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<GetStateListResponse> List(ListStatesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GetStateListResponse>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns the information on a specific state.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/state/{stateId}
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<GetStateInfoResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (stateId == null) throw new ArgumentException("Parameter cannot be null", nameof(stateId));

            return await rc.Get<GetStateInfoResponse>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public State.Index State(string stateId = null)
        {
            return new State.Index(this, stateId);
        }
    }
}