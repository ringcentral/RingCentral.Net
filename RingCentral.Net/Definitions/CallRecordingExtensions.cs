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
        public NavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPaging paging { get; set; }
    }
}