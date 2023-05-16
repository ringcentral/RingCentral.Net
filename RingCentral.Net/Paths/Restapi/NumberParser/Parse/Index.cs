using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.NumberParser.Parse
{
    public class Index
    {
        public NumberParser.Index parent;
        public RestClient rc;

        public Index(NumberParser.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/parse";
        }

        /// <summary>
        ///     Returns one or more parsed and/or formatted phone numbers that are passed as strings.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/number-parser/parse
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<ParsePhoneNumberResponse> Post(ParsePhoneNumberRequest parsePhoneNumberRequest,
            ParsePhoneNumberParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<ParsePhoneNumberResponse>(Path(), parsePhoneNumberRequest, queryParams,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.NumberParser
{
    public partial class Index
    {
        public Parse.Index Parse()
        {
            return new Parse.Index(this);
        }
    }
}