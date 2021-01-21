namespace RingCentral
{
    public class ReadCallSessionStatusParameters
    {
        /// <summary>
        /// The date and time of a call session latest change
        /// </summary>
        public string timestamp { get; set; }

        /// <summary>
        /// The time frame of awaiting for a status change before sending the resulting one in response
        /// </summary>
        public string timeout { get; set; }
    }
}