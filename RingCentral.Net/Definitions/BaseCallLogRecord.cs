namespace RingCentral
{
    /// <summary>
    ///     Base schema for CallLogRecord and CallLogRecordLegInfo
    /// </summary>
    public class BaseCallLogRecord
    {
        /// <summary>
        /// </summary>
        public ExtensionInfoCallLog extension { get; set; }

        /// <summary>
        ///     Telephony identifier of a call session
        /// </summary>
        public string telephonySessionId { get; set; }

        /// <summary>
        ///     Call session identifier, required for Telephony REST API
        /// </summary>
        public string sipUuidInfo { get; set; }

        /// <summary>
        /// </summary>
        public BaseCallLogRecordTransferTarget transferTarget { get; set; }

        /// <summary>
        /// </summary>
        public BaseCallLogRecordTransferee transferee { get; set; }

        /// <summary>
        ///     Internal Identifier of Participant
        /// </summary>
        public string partyId { get; set; }

        /// <summary>
        ///     The type of call transport. 'PSTN' indicates that a call leg was initiated
        ///     from the PSTN network provider; 'VoIP' - from an RC phone.
        ///     Enum: PSTN, VoIP
        /// </summary>
        public string transport { get; set; }

        /// <summary>
        /// </summary>
        public CallLogFromParty from { get; set; }

        /// <summary>
        /// </summary>
        public CallLogToParty to { get; set; }

        /// <summary>
        ///     The type of call
        ///     Required
        ///     Enum: Voice, Fax
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     The direction of a call
        ///     Required
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        /// </summary>
        public CallLogRecordMessage message { get; set; }

        /// <summary>
        /// </summary>
        public CallLogDelegateInfo @delegate { get; set; }

        /// <summary>
        ///     Call delegation type
        ///     Enum: Coworker, Unknown
        /// </summary>
        public string delegationType { get; set; }

        /// <summary>
        ///     The internal action corresponding to the call operation
        ///     Required
        ///     Enum: Accept Call, Barge In Call, Call Park, Call Return, CallOut-CallMe, Calling Card, Conference Call, E911
        ///     Update, Emergency, External Application, FindMe, FollowMe, FreeSPDL, Hunting, Incoming Fax, Monitoring, Move,
        ///     Outgoing Fax, Paging, Park Location, Phone Call, Phone Login, Pickup, RC Meetings, Ring Directly, RingMe, RingOut
        ///     Mobile, RingOut PC, RingOut Web, Sip Forwarding, Support, Text Relay, Transfer, Unknown, VoIP Call
        /// </summary>
        public string action { get; set; }

        /// <summary>
        ///     The result of the call operation
        ///     Enum: 911, 933, Abandoned, Accepted, Answered Not Accepted, Blocked, Busy, Call Failed, Call Failure, Call
        ///     connected, Carrier is not active, Declined, EDGE trunk misconfigured, Fax Not Sent, Fax Partially Sent, Fax Poor
        ///     Line, Fax Receipt Error, Fax on Demand, Hang Up, IP Phone Offline, In Progress, Internal Error, International
        ///     Disabled, International Restricted, Missed, No Answer, No Calling Credit, Not Allowed, Partial Receive, Phone
        ///     Login, Receive Error, Received, Rejected, Reply, Restricted Number, Send Error, Sent, Sent to Voicemail, Stopped,
        ///     Suspended account, Unknown, Voicemail, Wrong Number
        /// </summary>
        public string result { get; set; }

        /// <summary>
        ///     The reason of the call result:
        ///     * `Accepted` - The call was connected to and accepted by this number
        ///     * `Connected` - The call was answered, but there was no response on how to handle the call (for example, a voice
        ///     mail system answered the call and did not push "1" to accept)
        ///     * `Line Busy` - The phone number you dialed was busy
        ///     * `Not Answered` - The phone number you dialed was not answered
        ///     * `No Answer` - You did not answer the call
        ///     * `Hang Up` - The caller hung up before the call was answered
        ///     * `Stopped` - This attempt was stopped because the call was answered by another phone
        ///     * `Internal Error` - An internal error occurred when making the call. Please try again
        ///     * `No Credit` - There was not enough Calling Credit on your account to make this call
        ///     * `Restricted Number` - The number you dialed is restricted by RingCentral
        ///     * `Wrong Number` - The number you dialed has either been disconnected or is not a valid phone number. Please check
        ///     the number and try again
        ///     * `International Disabled` - International calling is not enabled on your account. Contact customer service to
        ///     activate International Calling
        ///     * `International Restricted` - The country and/or area you attempted to call has been prohibited by your
        ///     administrator
        ///     * `Bad Number` - An error occurred when making the call. Please check the number before trying again
        ///     * `Info 411 Restricted` - Calling to 411 Information Services is restricted
        ///     * `Customer 611 Restricted` - 611 customer service is not supported. Please contact customer service at <(888) 555-1212>
        ///     * `No Digital Line` - This DigitalLine was either not plugged in or did not have an internet connection
        ///     * `Failed Try Again` - Call failed. Please try again
        ///     * `Max Call Limit` - The number of simultaneous calls to your account has reached its limit
        ///     * `Too Many Calls` - The number of simultaneous calls for per DigitalLine associated with Other Phone has reached
        ///     its limit. Please contact customer service
        ///     * `Calls Not Accepted` - Your account was not accepting calls at this time
        ///     * `Number Not Allowed` - The number that was dialed to access your account is not allowed
        ///     * `Number Blocked` - This number is in your Blocked Numbers list
        ///     * `Number Disabled` - The phone number and/or area you attempted to call has been prohibited by your administrator
        ///     * `Resource Error` - An error occurred when making the call. Please try again
        ///     * `Call Loop` - A call loop occurred due to an incorrect call forwarding configuration. Please check that you are
        ///     not forwarding calls back to your own account
        ///     * `Fax Not Received` - An incoming fax could not be received because a proper connection with the sender's fax
        ///     machine could not be established
        ///     * `Fax Partially Sent` - The fax was only partially sent. Possible explanations include phone line quality to poor
        ///     to maintain the connection or the call was dropped
        ///     * `Fax Not Sent` - An attempt to send the fax was made, but could not connect with the receiving fax machine
        ///     * `Fax Poor Line` - An attempt to send the fax was made, but the phone line quality was too poor to send the fax
        ///     * `Fax Prepare Error` - An internal error occurred when preparing the fax. Please try again
        ///     * `Fax Save Error` - An internal error occurred when saving the fax. Please try again
        ///     * `Fax Send Error` - An error occurred when sending the fax. Please try again
        ///     * `Emergency Address not defined` - The call was rejected due to no E911 address
        ///     * `Carrier is not active` - The call was rejected due to carrier inactivity
        ///     * `EDGE trunk misconfigured` - The call was rejected due to error in EDGE trunk configuration
        ///     * `Internal Call Error` - An internal error occurred when making the call. Please try again
        ///     * `Receive Error` - Fax receive error
        ///     Enum: Accepted, Bad Number, Call Loop, Calls Not Accepted, Carrier is not active, Connected, Customer 611
        ///     Restricted, EDGE trunk misconfigured, Emergency Address not defined, Failed Try Again, Fax Not Received, Fax Not
        ///     Sent, Fax Partially Sent, Fax Poor Line, Fax Prepare Error, Fax Save Error, Fax Send Error, Hang Up, Info 411
        ///     Restricted, Internal Call Error, Internal Error, International Disabled, International Restricted, Line Busy, Max
        ///     Call Limit, No Answer, No Credit, No Digital Line, Not Answered, Number Blocked, Number Disabled, Number Not
        ///     Allowed, Receive Error, Resource Error, Restricted Number, Stopped, Too Many Calls, Unknown, Wrong Number
        /// </summary>
        public string reason { get; set; }

        /// <summary>
        ///     The detailed reason description of the call result
        /// </summary>
        public string reasonDescription { get; set; }

        /// <summary>
        ///     The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     Call duration in seconds
        ///     Format: int64
        /// </summary>
        public long? duration { get; set; }

        /// <summary>
        ///     Call duration in milliseconds
        ///     Format: int64
        /// </summary>
        public long? durationMs { get; set; }

        /// <summary>
        /// </summary>
        public CallLogRecordingInfo recording { get; set; }

        /// <summary>
        ///     Indicates that the recording is too short and therefore wouldn't be returned. The flag is not returned if the value
        ///     is false
        /// </summary>
        public bool? shortRecording { get; set; }

        /// <summary>
        /// </summary>
        public BillingInfo billing { get; set; }

        /// <summary>
        ///     The internal type of the call
        ///     Enum: Local, LongDistance, International, Sip, RingMe, RingOut, Usual, TollFreeNumber, VerificationNumber, Vma,
        ///     LocalNumber, ImsOutgoing, ImsIncoming, Unknown
        /// </summary>
        public string internalType { get; set; }
    }
}