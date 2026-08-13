namespace RingCentral
{
    public class CommCloudDestination
    {
        /// <summary>
        ///     Required
        ///     Example: 1111111
        /// </summary>
        public string integrationId { get; set; }

        /// <summary>
        ///     Example: 88888
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Example: +16509994313
        /// </summary>
        public string phoneNumber { get; set; }
    }
}