namespace RingCentral
{
    public class InteractionApiResponse
    {
        /// <summary>
        ///     Enum: Success, Fail
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public InteractionApiResponseResponse response { get; set; }
    }
}