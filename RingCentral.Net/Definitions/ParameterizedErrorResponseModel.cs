namespace RingCentral
{
    /// <summary>
    ///     Standard error response which may include parameterized errors
    /// </summary>
    public class ParameterizedErrorResponseModel
    {
        /// <summary>
        ///     The array of errors (there will be just one in the most of the cases)
        ///     Required
        /// </summary>
        public ApiErrorWithParameter[] errors { get; set; }
    }
}