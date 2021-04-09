namespace RingCentral
{
    public class CallRecordingExtensions
    {
        /// <summary>
        ///     Link to call recording extension list resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public CallRecordingExtensionInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public CallHandlingNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public CallHandlingPagingInfo paging { get; set; }
    }
}