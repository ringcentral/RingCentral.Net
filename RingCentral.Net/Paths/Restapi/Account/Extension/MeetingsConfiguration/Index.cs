namespace RingCentral.Paths.Restapi.Account.Extension.MeetingsConfiguration
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
            return $"{parent.Path()}/meetings-configuration";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public MeetingsConfiguration.Index MeetingsConfiguration()
        {
            return new MeetingsConfiguration.Index(this);
        }
    }
}