namespace RingCentral
{
    /// <summary>
    ///     Call queue member information
    /// </summary>
    public class CallQueueMember
    {
        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Extension full name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Extension number
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// </summary>
        public SiteResource site { get; set; }
    }
}