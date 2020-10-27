using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Presence
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/presence";
        }

        /// <summary>
        /// Operation: Get User Presence Status
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/presence
        /// Rate Limit Group: Light
        /// App Permission: ReadPresence
        /// User Permission: ReadPresenceStatus
        /// </summary>
        public async Task<RingCentral.GetPresenceInfo> Get(ReadUserPresenceStatusParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetPresenceInfo>(this.Path(), queryParams, restRequestConfig);
        }

        public async Task<BatchResponse<RingCentral.GetPresenceInfo>[]> BatchGet(
            ReadUserPresenceStatusParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (!this.Path().Contains(","))
            {
                throw new System.ArgumentException(
                    "In order to make a BatchGet, please specify multiple IDs delimited by ','");
            }

            return await rc.BatchGet<RingCentral.GetPresenceInfo>(this.Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update User Presence Status
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/presence
        /// Rate Limit Group: Medium
        /// App Permission: EditPresence
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.PresenceInfoResponse> Put(RingCentral.PresenceInfoResource presenceInfoResource,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.PresenceInfoResponse>(this.Path(), presenceInfoResource, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Presence.Index Presence()
        {
            return new Restapi.Account.Extension.Presence.Index(this);
        }
    }
}