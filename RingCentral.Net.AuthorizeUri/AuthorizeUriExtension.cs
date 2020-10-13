using System;
using System.Linq;

namespace RingCentral.Net.AuthorizeUri
{
    public class AuthorizeUriExtension : SdkExtension
    {
        private RestClient rc;

        public override void Install(RestClient rc)
        {
            this.rc = rc;
        }

        // todo: support PKCE
        public string BuildUri(AuthorizeRequest authorizeRequest)
        {
            if (authorizeRequest.response_type == null)
            {
                authorizeRequest.response_type = "code";
            }

            if (authorizeRequest.client_id == null)
            {
                authorizeRequest.client_id = this.rc.clientId;
            }

            var uriBuilder = new UriBuilder(this.rc.server)
            {
                Path = "/restapi/oauth/authorize",
                Query = string.Join("&",
                    Utils.GetPairs(authorizeRequest).Select(t => $"{t.name}={Uri.EscapeUriString(t.value.ToString())}"))
            };
            return uriBuilder.Uri.ToString();
        }
    }
}