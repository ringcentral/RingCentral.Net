namespace RingCentral
{
    // For 'Connect' or 'Voicemail' actions only. Extension reference
    public class IVRMenuExtensionInfo
    {
        /// <summary>
        ///     Link to an extension resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Name of an extension
        /// </summary>
        public string name { get; set; }
    }
}