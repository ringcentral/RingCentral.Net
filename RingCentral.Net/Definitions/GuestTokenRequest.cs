namespace RingCentral
{
    /// <summary>
    ///     Token endpoint request parameters used in the "Guest" authorization flow with the `guest` grant type
    /// </summary>
    public class GuestTokenRequest
    {
        /// <summary>
        ///     Grant type
        ///     Enum: guest
        /// </summary>
        public string grant_type { get; set; }

        /// <summary>
        ///     RingCentral Brand identifier.
        /// </summary>
        public string brand_id { get; set; }

        /// <summary>
        ///     Resource type for the guest access.
        /// </summary>
        public string resource_type { get; set; }

        /// <summary>
        ///     Resource URL for the guest access.
        /// </summary>
        public string resource { get; set; }
    }
}