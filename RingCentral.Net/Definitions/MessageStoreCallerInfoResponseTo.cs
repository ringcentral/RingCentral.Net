namespace RingCentral
{
    public class MessageStoreCallerInfoResponseTo
    {
        /// <summary>
        /// Extension short number (usually 3 or 4 digits). This property is filled when parties communicate by means of short internal numbers, for example when calling to other extension or sending/receiving Company Pager message
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// </summary>
        public string extensionId;

        /// <summary>
        /// Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers)
        /// </summary>
        public string location;

        /// <summary>
        /// 'True' specifies that message is sent exactly to this recipient. Returned in to field for group MMS. Useful if one extension has several phone numbers
        /// </summary>
        public bool? target;

        /// <summary>
        /// Status of a message. Returned for outbound fax messages only
        /// Enum: Queued, Sent, Delivered, DeliveryFailed, SendingFailed, Received
        /// </summary>
        public string messageStatus;

        /// <summary>
        /// Error code returned in case of fax sending failure. Returned if messageStatus value is 'SendingFailed'. Supported for fax messages only
        /// Enum: AllLinesInUse, Undefined, NoFaxSendPermission, NoInternationalPermission, NoFaxMachine, NoAnswer, LineBusy, CallerHungUp, NotEnoughCredits, SentPartially, InternationalCallingDisabled, DestinationCountryDisabled, UnknownCountryCode, NotAccepted, InvalidNumber, CallDeclined, TooManyCallsPerLine, CallFailed, RenderingFailed, TooManyPages, ReturnToDBQueue, NoCallTime, WrongNumber, ProhibitedNumber, InternalError, FaxSendingProhibited, ThePhoneIsBlacklisted, UserNotFound, ConvertError, DBGeneralError, SkypeBillingFailed, AccountSuspended, ProhibitedDestination, InternationalDisabled
        /// </summary>
        public string faxErrorCode;

        /// <summary>
        /// Symbolic name associated with a party. If the phone does not belong to the known extension, only the location is returned, the name is not determined then
        /// </summary>
        public string name;

        /// <summary>
        /// Phone number of a party. Usually it is a plain number including country and area code like 18661234567. But sometimes it could be returned from database with some formatting applied, for example (866)123-4567. This property is filled in all cases where parties communicate by means of global phone numbers, for example when calling to direct numbers or sending/receiving SMS
        /// </summary>
        public string phoneNumber;
    }
}