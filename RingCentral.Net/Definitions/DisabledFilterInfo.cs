namespace RingCentral
{
    public class DisabledFilterInfo
    {
        /// <summary>
        ///     Event filter that is disabled for the user
        /// </summary>
        public string filter { get; set; }

        /// <summary>
        ///     Reason why the filter is disabled for the user
        /// </summary>
        public string reason { get; set; }

        /// <summary>
        ///     Error message
        /// </summary>
        public string message { get; set; }
    }
}