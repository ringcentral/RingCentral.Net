namespace RingCentral
{
    public class AddForwardedNumberRequestItem
    {
        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Required
        ///     Example: +16501234567
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// </summary>
        public BulkOperationExtensionReference extension { get; set; }
    }
}