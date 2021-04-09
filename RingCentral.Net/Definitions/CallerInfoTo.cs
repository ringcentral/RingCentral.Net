namespace RingCentral
{
    public class CallerInfoTo
    {
        /// <summary>
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public string location { get; set; }

        /// <summary>
        ///     Enum: Sent, SendingFailed, Queued
        /// </summary>
        public string messageStatus { get; set; }

        /// <summary>
        ///     Enum: Undefined, NoFaxSendPermission, NoInternationalPermission, NoFaxMachine, NoAnswer, LineBusy, CallerHungUp,
        ///     NotEnoughCredits, SentPartially, InternationalCallingDisabled, DestinationCountryDisabled, UnknownCountryCode,
        ///     NotAccepted, InvalidNumber, CallDeclined, TooManyCallsPerLine, CallFailed, RenderingFailed, TooManyPages,
        ///     ReturnToDBQueue, NoCallTime, WrongNumber, ProhibitedNumber, InternalError, FaxSendingProhibited,
        ///     ThePhoneIsBlacklisted, UserNotFound, ConvertError, DBGeneralError, SkypeBillingFailed, AccountSuspended,
        ///     ProhibitedDestination, InternationalDisabled
        /// </summary>
        public string faxErrorCode { get; set; }
    }
}