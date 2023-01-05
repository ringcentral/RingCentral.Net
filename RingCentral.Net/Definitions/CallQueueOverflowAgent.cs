namespace RingCentral
{
    public class CallQueueOverflowAgent
    {
        /// <summary>
        ///     Internal identifier of a Call queue extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Extension number of call queue
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Name of a call queue
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Queue current state (Enabled/Disabled)
        ///     Enum: Disabled, Enabled
        /// </summary>
        public string status { get; set; }
    }
}