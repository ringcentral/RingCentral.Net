namespace RingCentral
{
    /// <summary>
    ///     To be used for direct number assignment in case number pool is not supported
    /// </summary>
    public class PhoneNumberDefinitionDirectNumberWithReservationId
    {
        /// <summary>
        ///     Phone number ID
        ///     Required
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Phone number reservation ID
        /// </summary>
        public string reservationId { get; set; }
    }
}