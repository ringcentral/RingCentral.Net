using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting.End
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Meeting.Index parent;

        public Index(Restapi.Account.Extension.Meeting.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/end";
        }

        /// <summary>
        /// Ends a meetings which is in progress.
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/end
        /// Rate Limit Group: Medium
        /// App Permission: Meetings
        /// User Permission: Meetings
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting
{
    public partial class Index
    {
        public Restapi.Account.Extension.Meeting.End.Index End()
        {
            return new Restapi.Account.Extension.Meeting.End.Index(this);
        }
    }
}