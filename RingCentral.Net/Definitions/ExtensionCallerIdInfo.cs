namespace RingCentral
{
    public class ExtensionCallerIdInfo
    {
        /// <summary>
        ///     Canonical URL of a caller ID resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public CallerIdByDevice[] byDevice { get; set; }

        /// <summary>
        /// </summary>
        public CallerIdByFeature[] byFeature { get; set; }

        /// <summary>
        ///     If 'True', then user first name and last name will be used as caller ID when making outbound calls from extension
        /// </summary>
        public bool? extensionNameForOutboundCalls { get; set; }

        /// <summary>
        ///     If 'True', then extension number will be used as caller ID when making internal calls
        /// </summary>
        public bool? extensionNumberForInternalCalls { get; set; }
    }
}