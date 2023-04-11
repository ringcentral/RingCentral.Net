namespace RingCentral
{
    public class CallLogRecordDeviceInfo
    {
        /// <summary>
        ///     Internal identifier of a device
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of a device resource
        ///     Required
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }
    }
}