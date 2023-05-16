namespace RingCentral
{
    /// <summary>
    ///     Swap device request
    /// </summary>
    public class SwapDeviceRequest
    {
        /// <summary>
        ///     Internal identifier of a target device, to which the current one will be swapped
        ///     Example: 8459879873
        /// </summary>
        public string targetDeviceId { get; set; }
    }
}