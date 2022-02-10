namespace RingCentral
{
    /// <summary>
    ///     Instance id of the caller. It corresponds to the 1st leg of the CallOut call.
    /// </summary>
    public class MakeCallOutCallerInfoRequestFrom
    {
        /// <summary>
        ///     Internal identifier of a device
        ///     Example: 59474004
        /// </summary>
        public string deviceId { get; set; }
    }
}