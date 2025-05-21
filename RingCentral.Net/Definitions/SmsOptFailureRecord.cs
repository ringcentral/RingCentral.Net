namespace RingCentral
{
    public class SmsOptFailureRecord
    {
        /// <summary>
        ///     The wildcard meaning that all account numbers should be opted out/in
        ///     Required
        ///     Example: +16501234567
        ///     Enum: *
        /// </summary>
        public string from { get; set; }

        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Required
        ///     Example: +16501234567
        /// </summary>
        public string to { get; set; }

        /// <summary>
        ///     Opt status of a recipient's phone number:
        ///     - `OptOut` - the number is opted out for SMS;
        ///     - `OptIn` - the number is opted in for SMS (if it was previously opted-out).
        ///     Required
        ///     Example: OptOut
        ///     Enum: OptOut, OptIn
        /// </summary>
        public string optStatus { get; set; }

        /// <summary>
        ///     The source of opt record
        ///     Required
        ///     Enum: Recipient, Api, Upstream, Carrier
        /// </summary>
        public string source { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public ApiError error { get; set; }
    }
}