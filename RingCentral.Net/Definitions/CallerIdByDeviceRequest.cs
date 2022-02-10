namespace RingCentral
{
    /// <summary>
    ///     Caller ID settings by device
    /// </summary>
    public class CallerIdByDeviceRequest
    {
        /// <summary>
        /// </summary>
        public CallerIdDeviceInfoRequest device { get; set; }

        /// <summary>
        /// </summary>
        public CallerIdByDeviceInfoRequest callerId { get; set; }
    }
}