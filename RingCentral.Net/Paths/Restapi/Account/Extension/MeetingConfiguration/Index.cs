namespace RingCentral.Paths.Restapi.Account.Extension.MeetingConfiguration
{
    public partial class Index
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
            return $"{parent.Path()}/meeting-configuration";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public MeetingConfiguration.Index MeetingConfiguration()
        {
            return new MeetingConfiguration.Index(this);
        }
    }
}