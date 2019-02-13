using System.Threading.Tasks;

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

        public async Task<RingCentral.ParsePhoneNumberResponse> Post(
            RingCentral.ParsePhoneNumberRequest parsePhoneNumberRequest, PostQueryParams queryParams = null)
        {
            return await rc.Post<RingCentral.ParsePhoneNumberResponse>(this.Path(), parsePhoneNumberRequest,
                queryParams);
        }

        public async Task<RingCentral.ParsePhoneNumberResponse> Post(object parsePhoneNumberRequest, object queryParams)
        {
            return await rc.Post<RingCentral.ParsePhoneNumberResponse>(this.Path(), parsePhoneNumberRequest,
                queryParams);
        }
    }

    public class PostQueryParams
    {
        // Internal identifier of a home country. The default value is ISO code (ISO 3166) of the user's home country or brand country, if the user is undefined
        public string homeCountry;

        // The default value is 'False'. If 'True', the numbers that are closer to the home country are given higher priority
        public bool? nationalAsPriority;
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