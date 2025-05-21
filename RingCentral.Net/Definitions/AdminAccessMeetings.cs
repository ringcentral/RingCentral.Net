namespace RingCentral
{
    /// <summary>
    ///     Meetings page
    /// </summary>
    public class AdminAccessMeetings
    {
        /// <summary>
        ///     Meetings array
        ///     Required
        /// </summary>
        public AdminAccessMeeting[] meetings { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public Paging paging { get; set; }
    }
}