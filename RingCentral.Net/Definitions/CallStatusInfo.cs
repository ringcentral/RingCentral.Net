namespace RingCentral
{
    public class CallStatusInfo
    {
        /// <summary>
        /// Status code of a call
        /// Enum: Setup, Proceeding, Answered, Disconnected, Gone, Parked, Hold, VoiceMail, FaxReceive, Tds, VoiceMailScreening
        /// </summary>
        public string code;

        /// <summary>
        /// Peer session / party data. Valid in Gone state only
        /// </summary>
        public PeerInfo peerId;

        /// <summary>
        /// Reason of call termination. For 'Disconnected' code only
        /// Enum: Pickup, Supervising, TakeOver, Timeout, BlindTransfer, RccTransfer, AttendedTransfer, CallerInputRedirect, CallFlip, ParkLocation, DtmfTransfer, AgentAnswered, AgentDropped, Rejected, Cancelled, InternalError, NoAnswer, TargetBusy, InvalidNumber, InternationalDisabled, DestinationBlocked, NotEnoughFunds, NoSuchUser, CallRedirected
        /// </summary>
        public string reason;

        /// <summary>
        /// Optional message
        /// </summary>
        public string description;
    }
}