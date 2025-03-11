namespace RingCentral
{
    public class AccountHistorySearchPublicRequest
    {
        /// <summary>
        ///     The beginning of the time range to return records in ISO 8601 format in UTC timezone, default is "eventTimeFrom"-24
        ///     hours
        ///     Format: date-time
        /// </summary>
        public string eventTimeFrom { get; set; }

        /// <summary>
        ///     The end of the time range to return records in ISO 8601 format in UTC timezone, default is the current time
        ///     Format: date-time
        /// </summary>
        public string eventTimeTo { get; set; }

        /// <summary>
        ///     List of extension IDs of change initiators.
        /// </summary>
        public string[] initiatorIds { get; set; }

        /// <summary>
        ///     Page number in the result set
        ///     Format: int32
        ///     Example: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Number of records to be returned per page.
        ///     Format: int32
        ///     Example: 25
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     List of extension (user) IDs affected by this action.
        ///     Example: 404611540004
        /// </summary>
        public string[] targetIds { get; set; }

        /// <summary>
        ///     Site ID to apply as a filter
        ///     Example: 871836004
        /// </summary>
        public string siteId { get; set; }

        /// <summary>
        ///     List of action IDs (exact keys) to search for (alternatively "excludeActionIds" option can be used).
        ///     Example: CHANGE_SECRET_INFO,CHANGE_USER_INFO
        /// </summary>
        public string[] actionIds { get; set; }

        /// <summary>
        ///     The (sub)string to search, applied to the following fields:
        ///     - initiator.name
        ///     - initiator.role
        ///     - initiator.extensionNumber
        ///     - target.name
        ///     - target.extensionNumber
        ///     - details.parameters.value
        ///     Example: 542617
        /// </summary>
        public string searchString { get; set; }

        /// <summary>
        ///     List of action IDs (exact keys) to exclude from your search (alternatively "actionIds" option can be used).
        ///     Example: CHANGE_SECRET_INFO,CHANGE_USER_INFO
        /// </summary>
        public string[] excludeActionIds { get; set; }
    }
}