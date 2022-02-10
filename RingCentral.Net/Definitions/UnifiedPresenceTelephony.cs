namespace RingCentral
{
    /// <summary>
    ///     Returned if *BLF* feature is switched on
    /// </summary>
    public class UnifiedPresenceTelephony
    {
        /// <summary>
        ///     Telephony status calculated from all user's phone numbers. Returned always for the requester's extension; returned
        ///     for another users if their telephony visibility is set to 'Visible'
        ///     Enum: NoCall, Ringing, CallConnected, OnHold, ParkedCall
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Specifies if the user hardphone presence status is visible to other users; returned only for requester's extension
        ///     Enum: Visible, Invisible
        /// </summary>
        public string visibility { get; set; }

        /// <summary>
        ///     Telephony DND status. Returned if *DND* feature is switched on
        ///     Enum: TakeAllCalls, DoNotAcceptAnyCalls, DoNotAcceptQueueCalls
        /// </summary>
        public string availability { get; set; }
    }
}