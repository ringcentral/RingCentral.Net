using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.CallOut
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
            return $"{parent.Path()}/call-out";
        }

        /// <summary>
        /// Operation: Create CallOut Call Session
        /// Http Post /restapi/v1.0/account/{accountId}/telephony/call-out
        /// </summary>
        public async Task<string> Post(RingCentral.MakeCallOutRequest makeCallOutRequest)
        {
            return await rc.Post<string>(this.Path(), makeCallOutRequest);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony
{
    public partial class Index
    {
        public Restapi.Account.Telephony.CallOut.Index CallOut()
        {
            return new Restapi.Account.Telephony.CallOut.Index(this);
        }
    }
}