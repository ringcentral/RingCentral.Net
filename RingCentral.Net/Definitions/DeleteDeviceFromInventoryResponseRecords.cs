namespace RingCentral
{
    public class DeleteDeviceFromInventoryResponseRecords
    {
        /// <summary>
        ///     Specifies if a device is successfully deleted
        /// </summary>
        public bool? bulkItemSuccessful { get; set; }

        /// <summary>
        ///     Internal identifier of a device
        /// </summary>
        public string deviceId { get; set; }

        /// <summary>
        ///     The list of errors occurred during processing of particular item of bulk operation.
        ///     Returned only if `bulkItemSuccessful` is false
        /// </summary>
        public ApiError[] bulkItemErrors { get; set; }
    }
}