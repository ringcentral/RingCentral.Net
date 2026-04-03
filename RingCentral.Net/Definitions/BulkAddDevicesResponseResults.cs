namespace RingCentral
{
    public class BulkAddDevicesResponseResults
    {
        /// <summary>
        ///     Indicates if the provisioning operation was successful for this item, always `false` in this model
        /// </summary>
        public bool? successful { get; set; }

        /// <summary>
        ///     Internal identifier of the created device
        ///     Example: 787878
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public BulkOperationExtensionReference extension { get; set; }

        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Example: +16501234567
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// </summary>
        public ApiErrorWithParameter[] errors { get; set; }
    }
}