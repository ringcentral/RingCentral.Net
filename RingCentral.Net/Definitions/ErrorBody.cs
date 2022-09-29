namespace RingCentral
{
    public class ErrorBody
    {
        /// <summary>
        ///     ANL error code
        ///     Required
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        ///     Detailed description of the error
        ///     Required
        /// </summary>
        public string message { get; set; }
    }
}