using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting.End
{
    public class Index
    {
        public Meeting.Index parent;
        public RestClient rc;

        public Index(Meeting.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/end";
        }

        /// <summary>
        ///     Ends a meetings which is in progress.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/end
        ///     Rate Limit Group: Medium
        ///     App Permission: Meetings
        ///     User Permission: Meetings
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting
{
    public partial class Index
    {
        public End.Index End()
        {
            return new End.Index(this);
        }
    }
}