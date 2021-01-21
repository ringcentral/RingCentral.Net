namespace RingCentral
{
    // RingOut status information
    public class RingOutStatusInfo
    {
        /// <summary>
        /// Status of a call
        /// Enum: Invalid, Success, InProgress, Busy, NoAnswer, Rejected, GenericError, Finished, InternationalDisabled, DestinationBlocked, NotEnoughFunds, NoSuchUser
        /// </summary>
        public string callStatus { get; set; }

        /// <summary>
        /// Status of a calling party
        /// Enum: Invalid, Success, InProgress, Busy, NoAnswer, Rejected, GenericError, Finished, InternationalDisabled, DestinationBlocked, NotEnoughFunds, NoSuchUser
        /// </summary>
        public string callerStatus { get; set; }

        /// <summary>
        /// Status of a called party
        /// Enum: Invalid, Success, InProgress, Busy, NoAnswer, Rejected, GenericError, Finished, InternationalDisabled, DestinationBlocked, NotEnoughFunds, NoSuchUser
        /// </summary>
        public string calleeStatus { get; set; }
    }
}