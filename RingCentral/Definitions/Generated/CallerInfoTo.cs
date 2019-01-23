namespace RingCentral
{
    public class CallerInfoTo : Serializable
    {
        public string phoneNumber;
        public string name;

        public string location;

        // Enum: Sent, SendingFailed, Queued
        public string messageStatus;

        // Enum: Undefined, NoFaxSendPermission, NoInternationalPermission, NoFaxMachine, OutgoingCallError, RenderingFailed, TooManyPages, ReturnToDBQueue, NoCallTime, WrongNumber, ProhibitedNumber, InternalError, FaxSendingProhibited, ThePhoneIsBlacklisted, UserNotFound, ConvertError, DBGeneralError, SkypeBillingFailed, AccountSuspended, ProhibitedDestination, InternationalDisabled
        public string faxErrorCode;
    }
}