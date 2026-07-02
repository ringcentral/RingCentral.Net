namespace RingCentral
{
    /// <summary>
    /// RingOut status information
    /// </summary>
    public class RingOutStatusInfo
    {
        /// <summary>
        ///     Status of a call and calling/called party
        ///     Enum: Invalid, Success, InProgress, Busy, NoAnswer, RingOutFromThisNumberIsNotSupported, Rejected, GenericError, Finished, InternationalDisabled, DestinationBlocked, NotEnoughFunds, NosuchUser, Error, CannotReach, NoAnsweringMachine, NoSessionFound, Unknown
        /// </summary>
        public string callStatus { get; set; }

        /// <summary>
        ///     Status of a call and calling/called party
        ///     Enum: Invalid, Success, InProgress, Busy, NoAnswer, RingOutFromThisNumberIsNotSupported, Rejected, GenericError, Finished, InternationalDisabled, DestinationBlocked, NotEnoughFunds, NosuchUser, Error, CannotReach, NoAnsweringMachine, NoSessionFound, Unknown
        /// </summary>
        public string callerStatus { get; set; }

        /// <summary>
        ///     Status of a call and calling/called party
        ///     Enum: Invalid, Success, InProgress, Busy, NoAnswer, RingOutFromThisNumberIsNotSupported, Rejected, GenericError, Finished, InternationalDisabled, DestinationBlocked, NotEnoughFunds, NosuchUser, Error, CannotReach, NoAnsweringMachine, NoSessionFound, Unknown
        /// </summary>
        public string calleeStatus { get; set; }
    }
}