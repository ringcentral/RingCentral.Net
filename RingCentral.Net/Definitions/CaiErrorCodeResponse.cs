namespace RingCentral
{
    public class CaiErrorCodeResponse
    {
        /// <summary>
        ///     Required
        ///     Enum: CAI-101, CAI-102, CAI-103, CAI-104, CAI-105, CAI-106, CAI-107, CAI-108, CAI-109, CAI-110
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        ///     Helpful description of the errorCode
        ///     Required
        /// </summary>
        public string message { get; set; }

        /// <summary>
        ///     Name of parameter if specified in the message
        /// </summary>
        public string parameterName { get; set; }
    }
}