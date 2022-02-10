namespace RingCentral
{
    /// <summary>
    ///     Format of response in case that any error occurred during request processing
    /// </summary>
    public class ADGErrorResponse
    {
        /// <summary>
        ///     Collection of all gathered errors
        /// </summary>
        public ADGError[] errors { get; set; }
    }
}