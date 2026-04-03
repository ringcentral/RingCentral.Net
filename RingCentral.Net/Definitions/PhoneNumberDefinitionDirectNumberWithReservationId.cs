namespace RingCentral
{
    /// <summary>
    /// Direct number assignment in case the number pool is not supported
    /// </summary>
    public class PhoneNumberDefinitionDirectNumberWithReservationId
    {
        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Required
        ///     Example: +16501234567
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Phone number reservation ID. If provided, phoneNumber is also required
        /// </summary>
        public string reservationId { get; set; }
    }
}