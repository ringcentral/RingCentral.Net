namespace RingCentral
{
    /// <summary>
    ///     The indication of a number to be deleted - either `id` or `phoneNumber` must be specified.
    /// </summary>
    public class DeletePhoneNumbersRequestItem
    {
        /// <summary>
        ///     Internal unique identifier of a phone number
        ///     Example: 1162820004
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Example: +16501234567
        /// </summary>
        public string phoneNumber { get; set; }
    }
}