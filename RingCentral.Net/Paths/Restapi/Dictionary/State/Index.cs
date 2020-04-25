using System.Threading.Tasks;
using System.Threading;

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
        /// Operation: Get States List
        /// Http Get /restapi/v1.0/dictionary/state
        /// </summary>
        public async Task<RingCentral.GetStateListResponse> List(ListStatesParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GetStateListResponse>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Get State
        /// Http Get /restapi/v1.0/dictionary/state/{stateId}
        /// </summary>
        public async Task<RingCentral.GetStateInfoResponse> Get(CancellationToken? cancellationToken = null)
        {
            if (this.stateId == null)
            {
                throw new System.ArgumentNullException("stateId");
            }

            return await rc.Get<RingCentral.GetStateInfoResponse>(this.Path(), null, cancellationToken);
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