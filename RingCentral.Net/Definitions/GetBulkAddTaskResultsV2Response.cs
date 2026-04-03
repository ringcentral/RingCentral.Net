namespace RingCentral
{
    public class GetBulkAddTaskResultsV2Response
    {
        /// <summary>
        ///     List of account phone numbers
        ///     Required
        /// </summary>
        public AddPhoneNumbersResponseItem[] records { get; set; }

        /// <summary>
        ///     Internal identifier of a task
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Task creation time in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Task status
        ///     Example: Accepted
        /// </summary>
        public string status { get; set; }
    }
}