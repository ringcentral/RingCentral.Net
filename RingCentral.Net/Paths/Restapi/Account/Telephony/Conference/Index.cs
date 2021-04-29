using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Telephony.Conference
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Telephony.Index parent;

        public Index(Restapi.Account.Telephony.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/conference";
        }

        /// <summary>
        /// Initiates a conference call session.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/conference
        /// Rate Limit Group: Heavy
        /// App Permission: CallControl
        /// </summary>
        public async Task<RingCentral.CallSessionObject> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CallSessionObject>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Conference.Index Conference()
        {
            return new Restapi.Account.Telephony.Conference.Index(this);
        }
    }
}