namespace RingCentral
{
    public class UiCallInfoRecord
    {
        /// <summary>
        ///     UI call info type
        ///     Enum: QueueName, CallerIdName
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     UI call info value
        ///     Example: John Doe
        /// </summary>
        public string value { get; set; }
    }
}