using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.NumberParser.Parse
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.NumberParser.Index parent;

        public Index(Restapi.NumberParser.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/parse";
        }

        /// <summary>
        /// Returns one or more parsed and/or formatted phone numbers that are passed as a string.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/number-parser/parse
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.ParsePhoneNumberResponse> Post(
            RingCentral.ParsePhoneNumberRequest parsePhoneNumberRequest,
            RingCentral.ParsePhoneNumberParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.ParsePhoneNumberResponse>(this.Path(), parsePhoneNumberRequest,
                queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.NumberParser
{
    public partial class Index
    {
        public Restapi.NumberParser.Parse.Index Parse()
        {
            return new Restapi.NumberParser.Parse.Index(this);
        }
    }
}