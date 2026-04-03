namespace RingCentral
{
    public class SmsConfigurationResource
    {
        /// <summary>
        ///     Internal identifier of a phone number
        /// </summary>
        public string phoneNumberId { get; set; }

        /// <summary>
        ///     Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) (with '+' sign) format
        ///     Example: +18661234567
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// </summary>
        public SmsCampaignInfo smsCampaignInfo { get; set; }

        /// <summary>
        /// </summary>
        public SmsBrandInfo smsBrandInfo { get; set; }
    }
}