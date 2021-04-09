namespace RingCentral
{
    // GCM data
    public class GCMInfo
    {
        /// <summary>
        ///     Notification priority, if the value is 'high' then notification is turned on even if the application is in
        ///     background
        ///     Enum: high, normal
        /// </summary>
        public string priority { get; set; }

        /// <summary>
        ///     Notification lifetime value in seconds, the default value is 30 seconds
        /// </summary>
        public long? time_to_live { get; set; }

        /// <summary>
        /// </summary>
        public GCMData data { get; set; }
    }
}