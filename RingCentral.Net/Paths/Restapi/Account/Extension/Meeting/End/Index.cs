using System.Threading.Tasks;
using System.Threading;

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
        /// Operation: End Meeting
        /// Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/end
        /// </summary>
        public async Task<string> Post(CancellationToken? cancellationToken = null)
        {
            return await rc.Post<string>(this.Path(), null, cancellationToken);
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