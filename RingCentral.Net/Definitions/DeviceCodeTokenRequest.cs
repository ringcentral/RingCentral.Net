namespace RingCentral
{
    /// <summary>
    ///     Token endpoint request parameters used in the "Device Authorization" flow
    ///     with the `urn:ietf:params:oauth:grant-type:device_code` grant type
    /// </summary>
    public class DeviceCodeTokenRequest
    {
        /// <summary>
        ///     Grant type
        ///     Required
        ///     Enum: urn:ietf:params:oauth:grant-type:device_code
        /// </summary>
        public string grant_type { get; set; }

        /// <summary>
        ///     For `urn:ietf:params:oauth:grant-type:device_code` grant type only.
        ///     The device verification code as defined by [RFC-8628](https://datatracker.ietf.org/doc/html/rfc8628#section-3.4)
        ///     Required
        /// </summary>
        public string device_code { get; set; }
    }
}