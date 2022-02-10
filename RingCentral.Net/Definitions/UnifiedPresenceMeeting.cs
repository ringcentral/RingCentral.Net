namespace RingCentral
{
    /// <summary>
    ///     Returned if *Meetings* feature is switched on
    /// </summary>
    public class UnifiedPresenceMeeting
    {
        /// <summary>
        ///     Meeting status calculated from all user`s meetings
        ///     Enum: NoMeeting, InMeeting
        /// </summary>
        public string status { get; set; }
    }
}