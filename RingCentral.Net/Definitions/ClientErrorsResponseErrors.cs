namespace RingCentral
{
    public class ClientErrorsResponseErrors
    {
        /// <summary>
        ///     Logical error code.
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        ///     Detailed user-friendly description of error.
        /// </summary>
        public string message { get; set; }

        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? parameterMaxItemCount { get; set; }

        /// <summary>
        ///     Name of the parameter with an invalid value.
        /// </summary>
        public string parameterName { get; set; }

        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? parameterValueLength { get; set; }

        /// <summary>
        /// </summary>
        public string parameterRange { get; set; }
    }
}