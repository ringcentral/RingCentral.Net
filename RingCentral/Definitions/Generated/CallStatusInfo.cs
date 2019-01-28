namespace RingCentral
{
    public class CallStatusInfo
    {
        // Status code of a call
        // Enum: Setup, Proceeding, Answered, Disconnected, Gone, Parked, Hold, VoiceMail, FaxReceive, Tds, VoiceMailScreening
        public string code;

        // Peer session / party data. Valid in Gone state only
        public PeerInfo peerId;

        // Reason of call termination. For 'Disconnected' code only
        // Enum: Pickup, Supervising, TakeOver, Timeout, BlindTransfer, RccTransfer, AttendedTransfer, CallerInputRedirect, CallFlip, ParkLocation, DtmfTransfer, AgentAnswered, AgentDropped, Rejected, Cancelled, InternalError, NoAnswer, TargetBusy, InvalidNumber, InternationalDisabled, DestinationBlocked, NotEnoughFunds, NoSuchUser, CallRedirected
        public string reason;

        // Optional message
        public string description;
    }
}