namespace RingCentral
{
    public class ReadA2PsmsOptOutsParameters
    {
        /// <summary>
        /// The sender's phone number (`from` field) in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format for filtering messages
        /// </summary>
        public string from;

        /// <summary>
        /// The reciever's phone number (`to` field) in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format for filtering messages
        /// </summary>
        public string to;

        /// <summary>
        /// Token of the page to be retrieved
        /// </summary>
        public string pageToken;

        /// <summary>
        /// Number of records to be returned for the page
        /// Default: 1000
        /// </summary>
        public long? perPage;
    }
}