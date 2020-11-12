using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RingCentral.Net.AuthorizeUri
{
    public class AuthorizeUriExtension : SdkExtension
    {
        private RestClient _rc;
        public string CodeVerifier { get; private set; }

        private readonly AuthorizeUriOptions _options;

        public AuthorizeUriExtension(AuthorizeUriOptions authorizeUriOptions = null)
        {
            _options = authorizeUriOptions ?? AuthorizeUriOptions.DefaultInstance;
        }

        public override Task Install(RestClient rc)
        {
            this._rc = rc;
            return Task.CompletedTask;
        }

        public string BuildUri(AuthorizeRequest authorizeRequest)
        {
            if (authorizeRequest.response_type == null)
            {
                authorizeRequest.response_type = "code";
            }

            if (authorizeRequest.client_id == null)
            {
                authorizeRequest.client_id = this._rc.clientId;
            }

            // PKCE: https://medium.com/ringcentral-developers/use-authorization-code-pkce-for-ringcentral-api-in-client-app-e9108f04b5f0
            if (authorizeRequest.code_challenge_method == "S256")
            {
                var randomBytes = new Byte[32];
                new Random().NextBytes(randomBytes);
                this.CodeVerifier = Convert.ToBase64String(randomBytes)
                    .Replace("+", "-")
                    .Replace("/", "_")
                    .Replace("=", "");
                var sha256Hash = new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(this.CodeVerifier));
                authorizeRequest.code_challenge = Convert.ToBase64String(sha256Hash)
                    .Replace("+", "-")
                    .Replace("/", "_")
                    .Replace("=", "");
            }

            var query = string.Join("&",
                Utils.GetPairs(authorizeRequest).Select(t => $"{t.name}={Uri.EscapeUriString(t.value.ToString())}"));
            UriBuilder uriBuilder;
            if (_options.baseUri == null)
            {
                uriBuilder = new UriBuilder(this._rc.server)
                {
                    Path = "/restapi/oauth/authorize",
                    Query = query
                };
            }
            else
            {
                uriBuilder = new UriBuilder(_options.baseUri)
                {
                    Query = query
                };
            }

            return uriBuilder.Uri.ToString();
        }
    }
}