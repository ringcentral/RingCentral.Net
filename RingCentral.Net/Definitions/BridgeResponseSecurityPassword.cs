namespace RingCentral
{
    public class BridgeResponseSecurityPassword
    {
        /// <summary>
        ///     Meeting password.
        ///     This field will be returned only if the request was done by bridge owner, his delegate or any user who has
        ///     the Super Admin privilege.
        ///     Example: Wq123ygs15
        /// </summary>
        public string plainText { get; set; }

        /// <summary>
        ///     Meeting password for PSTN users.
        ///     This field will be returned only if the request was done by bridge owner, his delegate or any user who has
        ///     the Super Admin privilege.
        ///     Example: 7492486829
        /// </summary>
        public string pstn { get; set; }

        /// <summary>
        ///     Meeting password hash.
        ///     This field will be returned only if the request was done by bridge owner, his delegate or any user who has
        ///     the Super Admin privilege.
        ///     Example: 99e4f8e6a241fc71279449a9c8f46eef
        /// </summary>
        public string joinQuery { get; set; }
    }
}