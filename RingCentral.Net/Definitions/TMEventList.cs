namespace RingCentral
{
    public class TMEventList
    {
        /// <summary>
        ///     List of events created by the current user
        /// </summary>
        public TMEventInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public TMNavigationInfo navigation { get; set; }
    }
}