using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Presence
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/presence";
        }

        /// <summary>
        ///     Returns the presence status of an extension or several extensions by their ID(s). The `presenceStatus` is returned
        ///     as Offline
        ///     (the parameters `telephonyStatus`, `message`, `userStatus` and `dndStatus` are not returned at all) for the
        ///     following extension types:
        ///     Department/Announcement Only/Take Messages Only (Voicemail)/Fax User/Paging Only Group/Shared Lines Group/IVR
        ///     Menu/Application Extension/Park Location.
        ///     If the user requests his/her own presence status, the response contains actual presence status even if the status
        ///     publication is turned off.
        ///     [Batch request syntax](https://developers.ringcentral.com/guide/basics/batch-requests) is supported. For batch
        ///     requests the number of extensions
        ///     in one request is limited to 30. If more extensions are included in the request, the error code 400 Bad Request is
        ///     returned with the logical error
        ///     code InvalidMultipartRequest and the corresponding message Extension Presence Info multipart request is limited to
        ///     30 extensions.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/presence
        ///     Rate Limit Group: Light
        ///     App Permission: ReadPresence
        ///     User Permission: ReadPresenceStatus
        /// </summary>
        public async Task<GetPresenceInfo> Get(ReadUserPresenceStatusParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GetPresenceInfo>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Updates user-defined extension presence status, status message and DnD status by extension ID. Supported for
        ///     regular User extensions only. The extension types listed do not support presence status: Department, Announcement
        ///     Only, Take Messages Only (Voicemail), Fax User, Paging Only Group, Shared Lines Group, IVR Menu, Application
        ///     Extension.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/presence
        ///     Rate Limit Group: Medium
        ///     App Permission: EditPresence
        /// </summary>
        public async Task<PresenceInfoResponse> Put(PresenceInfoRequest presenceInfoRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<PresenceInfoResponse>(Path(), presenceInfoRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Presence.Index Presence()
        {
            return new Presence.Index(this);
        }
    }
}