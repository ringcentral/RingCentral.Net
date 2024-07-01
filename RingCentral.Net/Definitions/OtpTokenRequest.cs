namespace RingCentral
{
    /// <summary>
    ///     Token endpoint request parameters used in the "One-time Password" (OTP) authorization flow with the `otp` grant
    ///     type
    /// </summary>
    public class OtpTokenRequest
    {
        /// <summary>
        ///     Grant type
        ///     Enum: otp
        /// </summary>
        public string grant_type { get; set; }

        /// <summary>
        ///     For `otp` grant type only.
        ///     One-time password code
        ///     Required
        /// </summary>
        public string code { get; set; }
    }
}