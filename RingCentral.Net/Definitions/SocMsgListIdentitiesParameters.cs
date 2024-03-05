namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation socMsgListIdentities
    /// </summary>
    public class SocMsgListIdentitiesParameters
    {
        /// <summary>
        ///     Filter based on the specified sourceId.
        /// </summary>
        public string sourceId { get; set; }

        /// <summary>
        ///     Filter based on the specified identityGroupId.
        /// </summary>
        public string identityGroupId { get; set; }

        /// <summary>
        ///     Filter based on the specified userId.
        /// </summary>
        public string userId { get; set; }

        /// <summary>
        ///     Filter based on the specified uuid.
        /// </summary>
        public string uuid { get; set; }

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