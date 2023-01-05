namespace RingCentral
{
    /// <summary>
    ///     Operator extension information. This extension will receive
    ///     all calls and messages addressed to an operator.
    /// </summary>
    public class AccountOperatorInfo
    {
        /// <summary>
        ///     Link to an operator extension resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of an operator extension
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Number of an operator extension
        /// </summary>
        public string extensionNumber { get; set; }
    }
}