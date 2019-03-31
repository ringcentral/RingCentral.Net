namespace RingCentral
{
    public class CallerInfoTo
    {
        /// <summary>
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// </summary>
        public string name;

        /// <summary>
        /// </summary>
        public string location;

        /// <summary>
        /// Enum: Sent, SendingFailed, Queued
        /// </summary>
        public string messageStatus;

        /// <summary>
        /// Enum: Undefined, NoFaxSendPermission, NoInternationalPermission, NoFaxMachine, OutgoingCallError, RenderingFailed, TooManyPages, ReturnToDBQueue, NoCallTime, WrongNumber, ProhibitedNumber, InternalError, FaxSendingProhibited, ThePhoneIsBlacklisted, UserNotFound, ConvertError, DBGeneralError, SkypeBillingFailed, AccountSuspended, ProhibitedDestination, InternationalDisabled
        /// </summary>
        public string faxErrorCode;
    }
}