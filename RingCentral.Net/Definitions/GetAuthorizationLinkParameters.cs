namespace RingCentral
{
    public class GetAuthorizationLinkParameters
    {
        /// <summary>
        /// This is a callback URI which determines where the response is sent. The value of this parameter must exactly match one of the URIs you have provided for your app upon registration
        /// </summary>
        public string redirect_uri;

        /// <summary>
        /// Determines authorization flow: **code** - Authorization Code, **token** - Implicit Grant
        /// Enum: code, token
        /// </summary>
        public string response_type;

        /// <summary>
        /// </summary>
        public string brand_id;

        /// <summary>
        /// Identifier (key) of a client application
        /// </summary>
        public string client_id;

        /// <summary>
        /// Specifies which login form will be displayed. Space-separated set of the following values: 'login' - official RingCentral login form, 'sso' - Single Sign-On login form, 'consent' - form to show the requested scope and prompt user for consent. Either 'login' or 'sso' (or both) must be specified. The default value is 'login&sso'
        /// Enum: login, sso, consent
        /// </summary>
        public string prompt;

        /// <summary>
        /// Style of login form. The 'popup' and 'touch' values are featured for mobile applications
        /// Default: page
        /// Enum: page, popup, touch, mobile
        /// </summary>
        public string display;

        /// <summary>
        /// Localization code of a language. Overwrites 'localeId' parameter value
        /// </summary>
        public string ui_locales;

        /// <summary>
        /// Localization code of a language. Overwrites 'Accept-Language' header value
        /// </summary>
        public string localeId;

        /// <summary>
        /// </summary>
        public string accept_language;

        /// <summary>
        /// User interface options data
        /// Enum: hide_logo, hide_tos, hide_remember_me, external_popup, old_ui
        /// </summary>
        public string ui_options;

        /// <summary>
        /// Client state. Returned back to the client at the end of the flow
        /// </summary>
        public string state;

        /// <summary>
        /// </summary>
        public string endpoint_id;

        /// <summary>
        /// </summary>
        public string request;

        /// <summary>
        /// </summary>
        public string request_uri;

        /// <summary>
        /// </summary>
        public string nonce;
    }
}