namespace RingCentral
{
    public class AccountHistorySearchPublicRequest
    {
        /// <summary>
        ///     UTC formatted datetime (RFC3339)
        ///     2019-10-12T07:20:50.52Z
        ///     Default: current time
        ///     Format: date-time
        /// </summary>
        public string eventTimeFrom { get; set; }

        /// <summary>
        ///     UTC formatted datetime (RFC3339)
        ///     2019-10-12T07:20:50.52Z
        ///     Default: dateFrom + 24h
        ///     Format: date-time
        /// </summary>
        public string eventTimeTo { get; set; }

        /// <summary>
        ///     List of extension IDs who is the user of changes.
        /// </summary>
        public string[] initiatorIds { get; set; }

        /// <summary>
        ///     Page number of the page you want to jump to.
        ///     Example: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Number of records returned per page.
        ///     Example: 25
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     List of extension IDs (users) affected by this action.
        ///     Example: 404611540004
        /// </summary>
        public string[] targetIds { get; set; }

        /// <summary>
        ///     A filter to apply by site ID
        ///     Example: 871836004
        /// </summary>
        public string siteId { get; set; }

        /// <summary>
        ///     List of action IDs (exact keys) to search for. Or you can use the excludeActionIds option.
        ///     Example: CHANGE_SECRET_INFO
        ///     Enum: CHANGE_SECRET_INFO, CHANGE_USER_INFO
        /// </summary>
        public string[] actionIds { get; set; }

        /// <summary>
        ///     List of fields to apply search on:
        ///     initiator.name
        ///     initiator.role
        ///     initiator.extensionNumber
        ///     target.name
        ///     target.extensionNumber
        ///     details.parameters.value
        ///     Example: 542617
        /// </summary>
        public string searchString { get; set; }

        /// <summary>
        ///     List of action IDs (exact keys) to exclude from your search. Or you can use the actionIds option.
        ///     Example: CHANGE_SECRET_INFO
        ///     Enum: CHANGE_SECRET_INFO, CHANGE_USER_INFO
        /// </summary>
        public string[] excludeActionIds { get; set; }
    }
}