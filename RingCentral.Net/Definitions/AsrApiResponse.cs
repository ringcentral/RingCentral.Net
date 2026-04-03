namespace RingCentral
{
    public class AsrApiResponse
    {
        /// <summary>
        ///     Enum: Success, Fail
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public AsrApiResponseResponse response { get; set; }
    }
}