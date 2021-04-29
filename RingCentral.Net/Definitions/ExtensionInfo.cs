namespace RingCentral
{
    // Information on the extension, to which the phone number is assigned. Returned only for the request of Account phone number list
    public class ExtensionInfo
    {
        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of an extension
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Extension name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Number of extension
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     For partner applications. Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension
        /// </summary>
        public string partnerId { get; set; }
    }
}