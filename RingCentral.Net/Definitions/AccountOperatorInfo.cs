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

        /// <summary>
        ///     Internal identifier of an extension created by partner. Supported for Partner Applications.
        ///     The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension
        ///     ID for each partner ID of a client application. In request URIs partner IDs are accepted instead
        ///     of regular RingCentral native IDs as path parameters using `pid=XXX` clause.
        ///     Though in response URIs contain the corresponding account IDs and extension
        ///     IDs. In all request and response bodies these values are reflected via
        ///     partnerId attributes of account and extension
        /// </summary>
        public string partnerId { get; set; }
    }
}