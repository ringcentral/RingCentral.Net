namespace RingCentral
{
    /// <summary>
    ///     Meetings page
    /// </summary>
    public class MeetingPage
    {
        /// <summary>
        ///     meetings array
        /// </summary>
        public Meeting[] meetings { get; set; }

        /// <summary>
        /// </summary>
        public Paging paging { get; set; }
    }
}