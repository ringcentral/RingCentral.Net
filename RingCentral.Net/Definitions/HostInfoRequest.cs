namespace RingCentral
{
    /// <summary>
    ///     Meeting host information
    /// </summary>
    public class HostInfoRequest
    {
        /// <summary>
        ///     Link to the meeting host resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of an extension which is assigned to be a meeting host. The default value is currently
        ///     logged-in extension identifier
        /// </summary>
        public string id { get; set; }
    }
}