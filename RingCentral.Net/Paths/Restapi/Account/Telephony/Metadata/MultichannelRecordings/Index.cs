namespace RingCentral.Paths.Restapi.Account.Telephony.Metadata.MultichannelRecordings
{
    public partial class Index
    {
        public string metadataId;
        public Metadata.Index parent;
        public RestClient rc;

        public Index(Metadata.Index parent, string metadataId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.metadataId = metadataId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && metadataId != null) return $"{parent.Path()}/multichannel-recordings/{metadataId}";

            return $"{parent.Path()}/multichannel-recordings";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Metadata
{
    public partial class Index
    {
        public MultichannelRecordings.Index MultichannelRecordings(
            string metadataId = null)
        {
            return new MultichannelRecordings.Index(this, metadataId);
        }
    }
}