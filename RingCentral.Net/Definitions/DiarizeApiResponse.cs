namespace RingCentral
{
    public class DiarizeApiResponse
    {
        /// <summary>
        ///     Enum: Success, Fail
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public DiarizeApiResponseResponse response { get; set; }
    }
}