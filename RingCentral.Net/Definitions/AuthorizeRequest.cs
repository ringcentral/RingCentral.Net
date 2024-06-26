namespace RingCentral
{
    public class AuthorizeRequest
    {
        /// <summary>
        ///     Determines authorization flow type. The only supported value is `code` which corresponds to OAuth 2.0
        ///     "Authorization Code Flow"
        ///     Required
        ///     Enum: code
        /// </summary>
        public string response_type { get; set; }

        /// <summary>
        ///     This is the URI where the Authorization Server redirects the User Agent to at the end of the authorization flow.
        ///     The value of this parameter must exactly match one of the URIs registered for this client application.
        ///     This parameter is required if there are more than one redirect URIs registered for the app.
        ///     Format: uri
        /// </summary>
        public string redirect_uri { get; set; }

        /// <summary>
        ///     The registered identifier of a client application
        ///     Required
        ///     Example: AZwEVwGEcfGet2PCouA7K6
        /// </summary>
        public string client_id { get; set; }

        /// <summary>
        ///     An opaque value used by the client to maintain state between the request and callback.
        ///     The authorization server includes this value when redirecting the User Agent back
        ///     to the client. The parameter SHOULD be used for preventing cross-site request forgery attacks.
        /// </summary>
        public string state { get; set; }

        /// <summary>
        ///     The list of requested OAuth scopes (space separated)
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        ///     Specifies how the Authorization Server displays the authentication and consent user interface pages to the
        ///     End-User.
        ///     Default: page
        ///     Enum: page, popup, touch, mobile
        /// </summary>
        public string display { get; set; }

        /// <summary>
        ///     Space-delimited, case-sensitive list of ASCII string values that specifies whether the Authorization Server prompts
        ///     the End-User for
        ///     re-authentication and consent. The defined values are:
        ///     - `login` - RingCentral native login form,
        ///     - `sso` - Single Sign-On login form,
        ///     - `consent` - form to show the requested scope and prompt user for consent.
        ///     Either `login` or `sso` (or both) must be specified. The default
        ///     value is `login sso`
        ///     Default: login sso
        /// </summary>
        public string prompt { get; set; }

        /// <summary>
        ///     End-User's preferred languages and scripts for the user interface, represented as a space-separated list of
        ///     [RFC-5646](https://datatracker.ietf.org/doc/html/rfc5646) language tag values, ordered by preference.
        ///     If this parameter is provided, its value overrides 'Accept-Language' header value and 'localeId' parameter value
        ///     (if any)
        ///     Example: en-US
        /// </summary>
        public string ui_locales { get; set; }

        /// <summary>
        ///     The code challenge value as defined by the PKCE specification -
        ///     [RFC-7636 "Proof Key for Code Exchange by OAuth Public Clients"](https://datatracker.ietf.org/doc/html/rfc7636)
        /// </summary>
        public string code_challenge { get; set; }

        /// <summary>
        ///     The code challenge method as defined by the PKCE specification -
        ///     [RFC-7636 "Proof Key for Code Exchange by OAuth Public Clients"](https://datatracker.ietf.org/doc/html/rfc7636)
        ///     Default: plain
        ///     Enum: plain, S256
        /// </summary>
        public string code_challenge_method { get; set; }

        /// <summary>
        ///     String value used to associate a Client session with an ID Token, and to mitigate replay attacks. The value is
        ///     passed through unmodified from the Authentication Request to the ID Token.
        /// </summary>
        public string nonce { get; set; }

        /// <summary>
        ///     Login form user interface options (space-separated). By default, the UI options that are registered for this client
        ///     application will be used
        /// </summary>
        public string ui_options { get; set; }

        /// <summary>
        ///     Hint to the Authorization Server about the login identifier the End-User might use to log in.
        /// </summary>
        public string login_hint { get; set; }

        /// <summary>
        ///     RingCentral Brand identifier. If it is not provided in the request,
        ///     server will try to determine brand from the client application profile.
        ///     Example: 1210
        /// </summary>
        public string brand_id { get; set; }

        /// <summary>
        /// </summary>
        public string accept_language { get; set; }
    }
}