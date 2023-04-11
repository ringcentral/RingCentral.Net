namespace RingCentral
{
    public class PunctuateApiOutput
    {
        /// <summary>
        ///     Enum: Success, Fail
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public PunctuateApiResponse response { get; set; }
    }
}