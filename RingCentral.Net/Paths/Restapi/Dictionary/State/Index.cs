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

        // Operation: Get State List
        // Http Get /restapi/v1.0/dictionary/state
        public async Task<RingCentral.GetStateListResponse> List(ListStatesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GetStateListResponse>(this.Path(false), queryParams);
        }

        // Operation: Get State
        // Http Get /restapi/v1.0/dictionary/state/{stateId}
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