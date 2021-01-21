namespace RingCentral
{
    public class AuthorizeRequest
    {
        /// <summary>
        /// Determines authorization flow: **code** - Authorization Code, **token** - Implicit Grant
        /// Enum: code, token
        /// </summary>
        public string response_type { get; set; }

        /// <summary>
        /// This is a callback URI which determines where the response is sent. The value of this parameter must exactly match one of the URIs you have provided for your app upon registration
        /// </summary>
        public string redirect_uri { get; set; }

        /// <summary>
        /// Identifier (key) of a client application
        /// </summary>
        public string client_id { get; set; }

        /// <summary>
        /// Client state. Returned back to the client at the end of the flow
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// Brand identifier. If it is not provided in request, server will try to determine brand from client app profile. The default value is '1210' - RingCentral US
        /// </summary>
        public string brand_id { get; set; }

        /// <summary>
        /// Style of login form. The default value is 'page'. The 'popup' and 'touch' values are featured for mobile applications
        /// Enum: page, popup, touch, mobile
        /// </summary>
        public string display { get; set; }

        /// <summary>
        /// Specifies which login form will be displayed. Space-separated set of the following values: 'login' - official RingCentral login form, 'sso' - Single Sign-On login form, 'consent' - form to show the requested scope and prompt user for consent. Either 'login' or 'sso' (or both) must be specified. The default value is 'login&sso'
        /// Enum: login, sso, consent
        /// </summary>
        public string prompt { get; set; }

        /// <summary>
        /// Localization code of a language. Overwrites 'Accept-Language' header value
        /// </summary>
        public string localeId { get; set; }

        /// <summary>
        /// Localization code of a language. Overwrites 'localeId' parameter value
        /// </summary>
        public string ui_locales { get; set; }

        /// <summary>
        /// User interface options data
        /// Enum: hide_logo, hide_tos, hide_remember_me, external_popup, old_ui
        /// </summary>
        public string ui_options { get; set; }

        /// <summary>
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        /// </summary>
        public string accept_language { get; set; }

        /// <summary>
        /// </summary>
        public string request { get; set; }

        /// <summary>
        /// </summary>
        public string request_uri { get; set; }

        /// <summary>
        /// </summary>
        public string nonce { get; set; }

        /// <summary>
        /// </summary>
        public string code_challenge { get; set; }

        /// <summary>
        /// Enum: plain, S256
        /// </summary>
        public string code_challenge_method { get; set; }

        /// <summary>
        /// </summary>
        public bool? discovery { get; set; }
    }
}