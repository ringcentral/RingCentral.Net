namespace RingCentral
{
    /// <summary>
    ///     Meetings page
    /// </summary>
    public class MeetingPage
    {
        /// <summary>
        ///     Meetings array
        ///     Required
        /// </summary>
        public Meeting[] meetings { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public BasicPaging paging { get; set; }
    }
}