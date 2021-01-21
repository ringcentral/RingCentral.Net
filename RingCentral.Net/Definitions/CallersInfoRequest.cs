namespace RingCentral
{
    public class CallersInfoRequest
    {
        /// <summary>
        /// Phone number of a caller
        /// </summary>
        public string callerId { get; set; }

        /// <summary>
        /// Contact name of a caller
        /// </summary>
        public string name { get; set; }
    }
}