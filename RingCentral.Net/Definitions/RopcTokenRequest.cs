namespace RingCentral
{
    /// <summary>
    ///     Token endpoint request parameters used in the "Password" (also known as "Resource Owner Password Credentials" -
    ///     ROPC)
    ///     authorization flow with the `password` grant type
    /// </summary>
    public class RopcTokenRequest
    {
        /// <summary>
        ///     Grant type
        ///     Required
        ///     Enum: password
        /// </summary>
        public string grant_type { get; set; }

        /// <summary>
        ///     For `password` grant type only. User login name: email or phone number in E.164 format
        ///     Required
        /// </summary>
        public string username { get; set; }

        /// <summary>
        ///     For `password` grant type only. User's password
        ///     Required
        ///     Format: password
        /// </summary>
        public string password { get; set; }

        /// <summary>
        ///     For `password` grant type only. Optional. Extension short number. If a company number
        ///     is specified as a username, and extension is not specified, the
        ///     server will attempt to authenticate client as main company administrator
        ///     DEPRECATED: use extension number embedded into username string like `+16501234567*101`
        /// </summary>
        public string extension { get; set; }

        /// <summary>
        ///     IVR pin for pin-based authentication.
        ///     DEPRECATED: use a dedicated `ivr_pin` grant type instead
        /// </summary>
        public string pin { get; set; }
    }
}