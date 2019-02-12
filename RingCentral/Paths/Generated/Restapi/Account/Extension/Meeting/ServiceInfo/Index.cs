using System.Threading.Tasks;

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

        public async Task<RingCentral.MeetingServiceInfoResource> Get()
        {
            return await rc.Get<RingCentral.MeetingServiceInfoResource>(this.Path());
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