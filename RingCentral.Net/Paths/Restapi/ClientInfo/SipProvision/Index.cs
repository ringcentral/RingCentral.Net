using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.ClientInfo.SipProvision
{
    public class Index
    {
        public ClientInfo.Index parent;
        public RestClient rc;

        public Index(ClientInfo.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/sip-provision";
        }

        /// <summary>
        ///     Creates SIP registration of a device/application (WebPhone, Mobile, softphone).
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/client-info/sip-provision
        ///     Rate Limit Group: Heavy
        ///     App Permission: VoipCalling
        /// </summary>
        public async Task<CreateSipRegistrationResponse> Post(
            CreateSipRegistrationRequest createSipRegistrationRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CreateSipRegistrationResponse>(Path(), createSipRegistrationRequest,
                null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.ClientInfo
{
    public partial class Index
    {
        public SipProvision.Index SipProvision()
        {
            return new SipProvision.Index(this);
        }
    }
}