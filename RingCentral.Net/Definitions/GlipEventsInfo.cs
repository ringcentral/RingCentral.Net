namespace RingCentral
{
    public class GlipEventsInfo
    {
        /// <summary>
        ///     List of events created by the current user
        /// </summary>
        public GlipEventInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public GlipNavigationInfo navigation { get; set; }
    }
}