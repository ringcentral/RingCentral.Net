namespace RingCentral
{
    /// <summary>
    ///     Standard error response model which is returned in case of any unsuccessful operation
    /// </summary>
    public class ApiErrorResponseModel
    {
        /// <summary>
        ///     The array of errors (there will be just one in the most of the cases)
        ///     Required
        /// </summary>
        public ApiError[] errors { get; set; }
    }
}