namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listSocialMessagingIdentities
    /// </summary>
    public class ListSocialMessagingIdentitiesParameters
    {
        /// <summary>
        ///     Filter based on the specified channelId.
        /// </summary>
        public string channelId { get; set; }

        /// <summary>
        ///     Filter based on the specified `identityGroupIds` (separated by commas)
        /// </summary>
        public string[] identityGroupIds { get; set; }

        /// <summary>
        ///     Either Agent or Customer
        ///     Enum: Agent, Customer
        /// </summary>
        public string identityType { get; set; }

        /// <summary>
        ///     Filter based on the specified `userId`
        /// </summary>
        public string userId { get; set; }

        /// <summary>
        ///     Filter based on the specified `uuid`
        /// </summary>
        public string uuid { get; set; }

        /// <summary>
        ///     Ordering by creationTime and lastModifiedTime is descending by default.
        ///     Example: +creationTime
        ///     Default: -creationTime
        ///     Enum: -creationTime, +creationTime, creationTime, -lastModifiedTime, +lastModifiedTime, lastModifiedTime
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