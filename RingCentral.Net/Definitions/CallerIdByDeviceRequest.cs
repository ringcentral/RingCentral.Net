namespace RingCentral
{
    // Caller ID settings by device
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