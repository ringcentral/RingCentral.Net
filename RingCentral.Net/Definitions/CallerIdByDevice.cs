namespace RingCentral
{
    /// <summary>
    ///     Caller ID settings by device
    /// </summary>
    public class CallerIdByDevice
    {
        /// <summary>
        /// </summary>
        public CallerIdDeviceInfo device { get; set; }

        /// <summary>
        /// </summary>
        public CallerIdByDeviceInfo callerId { get; set; }
    }
}