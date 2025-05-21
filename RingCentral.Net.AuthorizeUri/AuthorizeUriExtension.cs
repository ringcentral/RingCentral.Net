using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RingCentral.Net.AuthorizeUri
{
    // todo: this is temporary. After `AuthorizeRequest` adding back to spec, we can remove this class
    public class AuthorizeRequest
    {
        public string response_type { get; set; }
        public string client_id { get; set; }
        public string code_challenge_method { get; set; }
        public string code_challenge { get; set; }
        public string redirect_uri { get; set; }
        public string state { get; set; }
        public string ui_options { get; set; }
    }

    public class AuthorizeUriExtension : SdkExtension
    {
        private readonly AuthorizeUriOptions _options;
        private RestClient _rc;

        public AuthorizeUriExtension(AuthorizeUriOptions authorizeUriOptions = null)
        {
            _options = authorizeUriOptions ?? AuthorizeUriOptions.DefaultInstance;
        }

        public string CodeVerifier { get; private set; }

        public override Task Install(RestClient rc)
        {
            _rc = rc;
            return Task.CompletedTask;
        }

        public string BuildUri(AuthorizeRequest authorizeRequest)
        {
            if (authorizeRequest.response_type == null) authorizeRequest.response_type = "code";

            if (authorizeRequest.client_id == null) authorizeRequest.client_id = _rc.clientId;

            // PKCE: https://medium.com/ringcentral-developers/use-authorization-code-pkce-for-ringcentral-api-in-client-app-e9108f04b5f0
            if (authorizeRequest.code_challenge_method == "S256")
            {
                var randomBytes = new byte[32];
                new Random().NextBytes(randomBytes);
                CodeVerifier = Convert.ToBase64String(randomBytes)
                    .Replace("+", "-")
                    .Replace("/", "_")
                    .Replace("=", "");
                var sha256Hash = new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(CodeVerifier));
                authorizeRequest.code_challenge = Convert.ToBase64String(sha256Hash)
                    .Replace("+", "-")
                    .Replace("/", "_")
                    .Replace("=", "");
            }

            var query = string.Join("&",
                Utils.GetPairs(authorizeRequest).Select(t => $"{t.name}={Uri.EscapeDataString(t.value.ToString())}"));
            UriBuilder uriBuilder;
            if (_options.baseUri == null)
                uriBuilder = new UriBuilder(_rc.server)
                {
                    Path = "/restapi/oauth/authorize",
                    Query = query
                };
            else
                uriBuilder = new UriBuilder(_options.baseUri)
                {
                    Query = query
                };

            return uriBuilder.Uri.ToString();
        }
    }
}