namespace RingCentral
{
    public class MinimalSmsOptRecord
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
    }
}