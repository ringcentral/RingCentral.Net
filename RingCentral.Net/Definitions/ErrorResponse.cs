namespace RingCentral
{
    // Format of response in case that any error occured during request processing
    public class ErrorResponse
    {
        /// <summary>
        /// Collection of all gathered errors
        /// </summary>
        public Error[] errors;
    }
}