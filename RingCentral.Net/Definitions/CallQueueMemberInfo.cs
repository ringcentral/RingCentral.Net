namespace RingCentral
{
    public class CallQueueMemberInfo
    {
        /// <summary>
        ///     Link to a call queue member
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a call queue member
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Extension number of a call queue member
        /// </summary>
        public string extensionNumber { get; set; }
    }
}