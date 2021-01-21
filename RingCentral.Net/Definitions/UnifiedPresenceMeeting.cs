namespace RingCentral
{
    // Returned if *Meetings* feature is switched on
    public class UnifiedPresenceMeeting
    {
        /// <summary>
        /// Meeting status calculated from all user`s meetings
        /// Enum: NoMeeting, InMeeting
        /// </summary>
        public string status { get; set; }
    }
}