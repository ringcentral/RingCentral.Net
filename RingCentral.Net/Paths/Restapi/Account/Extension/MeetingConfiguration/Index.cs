namespace RingCentral.Paths.Restapi.Account.Extension.MeetingConfiguration
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
            return $"{parent.Path()}/meeting-configuration";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.MeetingConfiguration.Index MeetingConfiguration()
        {
            return new Restapi.Account.Extension.MeetingConfiguration.Index(this);
        }
    }
}