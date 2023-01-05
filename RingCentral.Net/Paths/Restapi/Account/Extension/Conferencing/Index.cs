using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Conferencing
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/conferencing";
        }

        /// <summary>
        ///     Returns information on Free Conference Calling (FCC) feature
        ///     for a given extension.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/conferencing
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: OrganizeConference
        /// </summary>
        public async Task<GetConferencingInfoResponse> Get(ReadConferencingSettingsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GetConferencingInfoResponse>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Updates the default conferencing number for the current extension.
        ///     The number can be selected from conferencing numbers of the current extension.
        ///     Updates the setting, allowing participants join the conference before host.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/conferencing
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: OrganizeConference
        /// </summary>
        public async Task<GetConferencingInfoResponse> Put(UpdateConferencingInfoRequest updateConferencingInfoRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<GetConferencingInfoResponse>(Path(), updateConferencingInfoRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Conferencing.Index Conferencing()
        {
            return new Conferencing.Index(this);
        }
    }
}