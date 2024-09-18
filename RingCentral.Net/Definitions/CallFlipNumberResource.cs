namespace RingCentral
{
    public class CallFlipNumberResource
    {
        /// <summary>
        ///     Internal identifier of a call flip number
        ///     Example: 409926525004
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Flip number in E.164 format with '+'
        ///     Example: +16502096935
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Flip number type
        ///     Example: PhoneLine
        ///     Enum: PhoneLine, External
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Flip number label, device name for Digital Line case
        ///     Example: My Mobile Number
        /// </summary>
        public string label { get; set; }

        /// <summary>
        ///     Speed dial/flip number, the range is 1-8
        ///     Example: 5
        /// </summary>
        public string flipNumber { get; set; }
    }
}