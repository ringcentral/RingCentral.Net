namespace RingCentral
{
    /// <summary>
    ///     Status data of a call session
    /// </summary>
    public class CallStatusInfo
    {
        /// <summary>
        ///     Status code of a call
        ///     Enum: Setup, Proceeding, Answered, Disconnected, Gone, Parked, Hold, VoiceMail, FaxReceive, VoiceMailScreening
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// </summary>
        public PeerInfo peerId { get; set; }

        /// <summary>
        ///     Reason for call termination. For 'Disconnected' code only
        ///     Enum: Pickup, Supervising, TakeOver, Timeout, BlindTransfer, RccTransfer, AttendedTransfer, CallerInputRedirect,
        ///     CallFlip, ParkLocation, DtmfTransfer, AgentAnswered, AgentDropped, Rejected, Cancelled, InternalError, NoAnswer,
        ///     TargetBusy, InvalidNumber, InternationalDisabled, DestinationBlocked, NotEnoughFunds, NoSuchUser, CallPark,
        ///     CallRedirected, CallReplied, CallSwitch, CallFinished, CallDropped
        /// </summary>
        public string reason { get; set; }

        /// <summary>
        ///     Optional message
        /// </summary>
        public string description { get; set; }
    }
}