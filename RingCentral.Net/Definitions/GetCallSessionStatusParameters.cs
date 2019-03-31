namespace RingCentral
{
    public class GetCallSessionStatusParameters
    {
        /// <summary>
        /// The date and time of a call session latest change
        /// </summary>
        public string timestamp;

        /// <summary>
        /// The time frame of awaiting for a status change before sending the resulting one in response
        /// </summary>
        public string timeout;
    }
}