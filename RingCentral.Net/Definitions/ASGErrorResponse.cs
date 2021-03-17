namespace RingCentral
{
    // Error response
    public class ASGErrorResponse
    {
        /// <summary>
        /// Error code
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        /// Human-readable description of an error. Not suitable for end users
        /// </summary>
        public string description { get; set; }
    }
}