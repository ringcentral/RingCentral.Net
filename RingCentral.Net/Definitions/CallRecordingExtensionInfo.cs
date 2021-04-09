namespace RingCentral
{
    public class CallRecordingExtensionInfo
    {
        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to an extension resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Number of an extension
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Name of an extension
        /// </summary>
        public string name { get; set; }
    }
}