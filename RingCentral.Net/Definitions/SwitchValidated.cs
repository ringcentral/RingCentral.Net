namespace RingCentral
{
    public class SwitchValidated
    {
        /// <summary>
        ///     Internal identifier of a switch
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Unique identifier of a network switch
        /// </summary>
        public string chassisId { get; set; }

        /// <summary>
        ///     Switch entity extension for better diversity. Should be used together with chassisId.
        /// </summary>
        public string port { get; set; }

        /// <summary>
        ///     Validation result status
        ///     Enum: Valid, Invalid
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public ValidationError[] errors { get; set; }
    }
}