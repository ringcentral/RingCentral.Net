namespace RingCentral
{
    public class SpeakerIdentifyApiResponse
    {
        /// <summary>
        ///     Enum: Success, Fail
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public SpeakerIdentifyApiResponseResponse response { get; set; }
    }
}