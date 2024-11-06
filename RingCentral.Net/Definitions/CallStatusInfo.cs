namespace RingCentral
{
    /// <summary>
    ///     Status data of a call session
    /// </summary>
    public class CallStatusInfo
    {
        /// <summary>
        ///     Status code of a call
        ///     Enum: Setup, Proceeding, Answered, Disconnected, Gone, Parked, Hold, VoiceMail, FaxReceive, Tds, VoiceMailScreening
        /// </summary>
        public string code { get; set; }

        /// <summary>
        ///     Reason for a call status, might be specified for some codes
        ///     Enum: Pickup, Supervising, TakeOver, Timeout, BlindTransfer, RccTransfer, AttendedTransfer, CallerInputRedirect,
        ///     CallFlip, ParkLocation, DtmfTransfer, AgentAnswered, AgentDropped, Rejected, Cancelled, InternalError, NoAnswer,
        ///     TargetBusy, InvalidNumber, InternationalDisabled, DestinationBlocked, NotEnoughFunds, NoSuchUser, CallPark,
        ///     CallRedirected, CallReplied, CallSwitch, CallFinished, CallDropped, Voicemail
        /// </summary>
        public string reason { get; set; }

        /// <summary>
        ///     Optional message
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     Call park data. Returned for calls in 'Parked' state
        /// </summary>
        public string parkData { get; set; }

        /// <summary>
        /// </summary>
        public PeerInfo peerId { get; set; }

        /// <summary>
        /// </summary>
        public MobilePickupData mobilePickupData { get; set; }

        /// <summary>
        ///     Specifies if it's a conference call
        /// </summary>
        public bool? rcc { get; set; }
    }
}