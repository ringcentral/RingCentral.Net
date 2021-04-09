namespace RingCentral
{
    public class UserVideoConfiguration
    {
        /// <summary>
        ///     Video provider of the user
        ///     Enum: RCMeetings, RCVideo, None
        /// </summary>
        public string provider { get; set; }

        /// <summary>
        ///     Specifies if the user is 'paid' (has meeting license) or 'free' (w/o meeting license)
        ///     Enum: Paid, Free
        /// </summary>
        public string userLicenseType { get; set; }
    }
}