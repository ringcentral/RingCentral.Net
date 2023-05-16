namespace RingCentral
{
    public class BulkAddDevicesSuccessItem
    {
        /// <summary>
        ///     Indicates if the provisioning operation was successful for this item, always `true` in this model
        ///     Required
        ///     Example: true
        /// </summary>
        public bool? successful { get; set; }

        /// <summary>
        ///     Internal identifier of the created device
        ///     Required
        ///     Example: 787878
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public BulkOperationExtensionReference extension { get; set; }

        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Required
        ///     Example: +16501234567
        /// </summary>
        public string phoneNumber { get; set; }
    }
}