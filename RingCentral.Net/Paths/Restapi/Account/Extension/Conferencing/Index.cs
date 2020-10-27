using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Conferencing
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
            return $"{parent.Path()}/conferencing";
        }

        /// <summary>
        /// Operation: Get User Conferencing Settings
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: OrganizeConference
        /// </summary>
        public async Task<RingCentral.GetConferencingInfoResponse> Get(
            ReadConferencingSettingsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetConferencingInfoResponse>(this.Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update User Conferencing Settings
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: OrganizeConference
        /// </summary>
        public async Task<RingCentral.GetConferencingInfoResponse> Put(
            RingCentral.UpdateConferencingInfoRequest updateConferencingInfoRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.GetConferencingInfoResponse>(this.Path(), updateConferencingInfoRequest,
                null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Conferencing.Index Conferencing()
        {
            return new Restapi.Account.Extension.Conferencing.Index(this);
        }
    }
}