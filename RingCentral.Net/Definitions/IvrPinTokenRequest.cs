namespace RingCentral
{
    /// <summary>
    ///     Token endpoint request parameters used in the "IVR Pin" authorization flow with the `ivr_pin` grant type
    /// </summary>
    public class IvrPinTokenRequest
    {
        /// <summary>
        ///     Grant type
        ///     Enum: ivr_pin
        /// </summary>
        public string grant_type { get; set; }

        /// <summary>
        ///     For `ivr_pin` grant type only. User's IVR pin.
        ///     Required
        /// </summary>
        public string ivr_pin { get; set; }
    }
}