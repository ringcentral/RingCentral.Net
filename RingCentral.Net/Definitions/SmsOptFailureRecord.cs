namespace RingCentral
{
    public class SmsOptFailureRecord
    {
        /// <summary>
        ///     The wildcard ('*') indicating that all account numbers should be opted out or opted in
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
        ///     Consent status of a recipient's phone number:
        ///     - `OptOut` - The number is opted out of receiving SMS.
        ///     - `OptIn` - The number is opted in to receiving SMS (if it was previously opted out).
        ///     Required
        ///     Example: OptOut
        ///     Enum: OptOut, OptIn
        /// </summary>
        public string optStatus { get; set; }

        /// <summary>
        ///     The source of the consent record
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