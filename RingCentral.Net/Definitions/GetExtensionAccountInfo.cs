namespace RingCentral
{
    /// <summary>
    ///     Account information
    /// </summary>
    public class GetExtensionAccountInfo
    {
        /// <summary>
        ///     Internal identifier of an account
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of an account resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }
    }
}