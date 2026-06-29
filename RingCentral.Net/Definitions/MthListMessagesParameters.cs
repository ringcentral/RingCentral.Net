namespace RingCentral
{
    /// <summary>
    /// Query parameters for operation mthListMessages
    /// </summary>
    public class MthListMessagesParameters
    {
        /// <summary>
        ///     Thread status
        ///     Enum: Open, Resolved
        /// </summary>
        public string threadStatus { get; set; }

        /// <summary>
        ///     Thread owner extension IDs
        /// </summary>
        public string[] ownerExtensionIds { get; set; }

        /// <summary>
        ///     Availability filter (by default only `Alive` records are returned)
        ///     Default: Alive
        ///     Enum: Alive, Deleted
        /// </summary>
        public string[] availability { get; set; }

        /// <summary>
        ///     Message IDs to filter the list of results
        /// </summary>
        public string[] messageIds { get; set; }

        /// <summary>
        ///     Thread ID(s) to filter messages
        /// </summary>
        public string[] threadIds { get; set; }

        /// <summary>
        ///     Start date/time for resulting message threads or messages (depending on path resource) 
        ///     in [RFC-3339](https://datatracker.ietf.org/doc/html/rfc3339) format including timezone. 
        ///     This parameter is supported if `creationTimeTo` is specified
        /// </summary>
        public string creationTimeFrom { get; set; }

        /// <summary>
        ///     End date/time for resulting message threads or messages (depending on path resource) 
        ///     in [RFC-3339](https://datatracker.ietf.org/doc/html/rfc3339) format including timezone. 
        ///     This parameter is supported if `creationTimeFrom` is specified
        /// </summary>
        public string creationTimeTo { get; set; }

        /// <summary>
        ///     The number of items per page. If the provided value in the request
        ///     is greater than a maximum, the maximum value is applied
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 100
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     The result set page number (1-indexed) to return
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 1
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }
    }
}