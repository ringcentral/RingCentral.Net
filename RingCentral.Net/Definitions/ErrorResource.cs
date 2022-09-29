namespace RingCentral
{
    /// <summary>
    ///     Standard error resource which is returned in case of any unsuccessful operation
    /// </summary>
    public class ErrorResource
    {
        /// <summary>
        ///     The array of errors (there will be just one in the most of cases)
        ///     Required
        /// </summary>
        public ResponseErrorModel[] errors { get; set; }
    }
}