namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation socMsgListContents
    /// </summary>
    public class SocMsgListContentsParameters
    {
        /// <summary>
        ///     Filter based on the specified intervention identifiers.
        ///     Example: 7f946431b6eebffafae642cc,re946431b6eebffafae642cc
        /// </summary>
        public string[] intervention { get; set; }

        /// <summary>
        ///     Filter based on the specified identity identifiers.
        ///     Example: 7f946431b6eebffafae642cc,re946431b6eebffafae642cc
        /// </summary>
        public string[] identity { get; set; }

        /// <summary>
        ///     Filter based on the specified identity group identifiers.
        ///     Example: 7f946431b6eebffafae642cc,re946431b6eebffafae642cc
        /// </summary>
        public string[] identityGroup { get; set; }

        /// <summary>
        ///     Filter based on the specified channel identifiers.
        ///     Example: 7f946431b6eebffafae642cc
        /// </summary>
        public string[] source { get; set; }

        /// <summary>
        ///     Filter based on the specified thread identifiers.
        ///     Example: 7f946431b6eebffafae642cc
        /// </summary>
        public string[] thread { get; set; }

        /// <summary>
        ///     Filter based on the specified text(s). Provided multiple times, the values are ANDed.
        /// </summary>
        public string[] text { get; set; }

        /// <summary>
        ///     Filter for specified status.
        ///     Enum: New, Assigned, Replied, UserReply, UserInitiated, Ignored
        /// </summary>
        public string[] status { get; set; }

        /// <summary>
        ///     Ordering by creationTime is descending by default.
        ///     Example: +creationTime
        ///     Default: -creationTime
        ///     Enum: -creationTime, +creationTime, creationTime
        /// </summary>
        public string orderBy { get; set; }

        /// <summary>
        ///     The token indicating the particular page of the result set to be retrieved.
        ///     If omitted the first page will be returned.
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     The number of items per page. If provided value in the request
        ///     is greater than a maximum, the maximum value is applied
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 100
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }
    }
}