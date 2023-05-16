namespace RingCentral
{
    public class BulkAddDevicesItemPhoneInfo
    {
        /// <summary>
        ///     Indicates if a number is toll or toll-free
        ///     Example: Toll
        ///     Enum: Toll, TollFree
        /// </summary>
        public string tollType { get; set; }

        /// <summary>
        ///     Preferred area code to use if numbers available
        ///     Example: 650
        /// </summary>
        public string preferredAreaCode { get; set; }

        /// <summary>
        ///     Phone number ID
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Phone number reservation ID
        /// </summary>
        public string reservationId { get; set; }

        /// <summary>
        ///     Phone number ID
        /// </summary>
        public string phoneNumberId { get; set; }
    }
}