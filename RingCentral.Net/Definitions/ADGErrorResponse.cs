namespace RingCentral
{
    // Format of response in case that any error occurred during request processing
    public class ADGErrorResponse
    {
        /// <summary>
        ///     Collection of all gathered errors
        /// </summary>
        public ADGError[] errors { get; set; }
    }
}