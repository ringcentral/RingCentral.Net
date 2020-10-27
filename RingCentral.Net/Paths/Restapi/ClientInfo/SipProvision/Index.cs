using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.ClientInfo.SipProvision
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.ClientInfo.Index parent;

        public Index(Restapi.ClientInfo.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/sip-provision";
        }

        /// <summary>
        /// Operation: Register Device
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/client-info/sip-provision
        /// Rate Limit Group: Heavy
        /// App Permission: VoipCalling
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.CreateSipRegistrationResponse> Post(
            RingCentral.CreateSipRegistrationRequest createSipRegistrationRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CreateSipRegistrationResponse>(this.Path(), createSipRegistrationRequest,
                null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.ClientInfo
{
    public partial class Index
    {
        public Restapi.ClientInfo.SipProvision.Index SipProvision()
        {
            return new Restapi.ClientInfo.SipProvision.Index(this);
        }
    }
}