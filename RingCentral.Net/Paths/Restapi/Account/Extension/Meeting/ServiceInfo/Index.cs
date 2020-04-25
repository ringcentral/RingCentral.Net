using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting.ServiceInfo
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
            return $"{parent.Path()}/service-info";
        }

        /// <summary>
        /// Operation: Get Meeting Service Info
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/service-info
        /// </summary>
        public async Task<RingCentral.MeetingServiceInfoResource> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.MeetingServiceInfoResource>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Meeting Service Info
        /// Http Patch /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/service-info
        /// </summary>
        public async Task<RingCentral.MeetingServiceInfoResource> Patch(
            RingCentral.MeetingServiceInfoRequest meetingServiceInfoRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Patch<RingCentral.MeetingServiceInfoResource>(this.Path(), meetingServiceInfoRequest, null,
                cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting
{
    public partial class Index
    {
        public Restapi.Account.Extension.Meeting.ServiceInfo.Index ServiceInfo()
        {
            return new Restapi.Account.Extension.Meeting.ServiceInfo.Index(this);
        }
    }
}