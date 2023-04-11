namespace RingCentral
{
    public class SummaryApiOutput
    {
        /// <summary>
        ///     Enum: Success, Fail
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public SummaryApiResponse response { get; set; }
    }
}