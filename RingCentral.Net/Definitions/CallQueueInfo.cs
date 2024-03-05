namespace RingCentral
{
    public class CallQueueInfo
    {
        /// <summary>
        ///     Link to a call queue
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a call queue
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Extension number of a call queue
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Name of a call queue
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Call queue status
        ///     Enum: Enabled, Disabled, NotActivated
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Indicates whether it is an emergency call queue extension or not
        ///     Enum: Emergency
        /// </summary>
        public string subType { get; set; }
    }
}