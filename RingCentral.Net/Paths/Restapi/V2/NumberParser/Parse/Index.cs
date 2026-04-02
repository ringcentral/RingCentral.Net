using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.NumberParser.Parse
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.V2.NumberParser.Index parent;
public Index(Restapi.V2.NumberParser.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/parse";
        }
        /// <summary>
        /// Parses, formats, and validates phone numbers provided as a list of strings.
        /// HTTP Method: post
        /// Endpoint: /restapi/v2/number-parser/parse
        /// Rate Limit Group: Light
        /// </summary>
  public async Task<RingCentral.ParsePhoneNumberResponseV2> Post(RingCentral.ParsePhoneNumbersRequest parsePhoneNumbersRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.ParsePhoneNumberResponseV2>(this.Path(), parsePhoneNumbersRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.V2.NumberParser
{
    public partial class Index
    {
        public Restapi.V2.NumberParser.Parse.Index Parse()
        {
            return new Restapi.V2.NumberParser.Parse.Index(this);
        }
    }
}