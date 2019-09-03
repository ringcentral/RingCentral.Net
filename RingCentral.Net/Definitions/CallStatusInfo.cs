namespace RingCentral
{
    public class CallStatusInfo
    {
        /// <summary>
        /// Status code of a call
        /// Enum: Setup, Proceeding, Answered, Disconnected, Gone, Parked, Hold, VoiceMail, FaxReceive, VoiceMailScreening
        /// </summary>
        public string code;

        /// <summary>
        /// Peer session / party data.'Gone'state only
        /// </summary>
        public PeerInfo peerId;

        /// <summary>
        /// Reason of call termination. For 'Disconnected' code only
        /// Enum: Pickup, Supervising, TakeOver, Timeout, BlindTransfer, RccTransfer, AttendedTransfer, CallerInputRedirect, CallFlip, ParkLocation, DtmfTransfer, AgentAnswered, AgentDropped, Rejected, Cancelled, InternalError, NoAnswer, TargetBusy, InvalidNumber, InternationalDisabled, DestinationBlocked, NotEnoughFunds, NoSuchUser, CallRedirected, CallReplied, CallFinished, CallDropped
        /// </summary>
        public string reason;

        /// <summary>
        /// Optional message
        /// </summary>
        public string description;
    }
}