namespace RingCentral
{
    public class ListChatTasksParameters
    {
        /// <summary>
        /// The end datetime for resulting records in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, e.g. 2019-03-10T18:23:45Z
        /// Default: now
        /// </summary>
        public string creationTimeTo { get; set; }

        /// <summary>
        /// The start datetime for resulting records in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, e.g. 2016-02-23T00:00:00
        /// </summary>
        public string creationTimeFrom { get; set; }

        /// <summary>
        /// Internal identifier of a task creator
        /// </summary>
        public string[] creatorId { get; set; }

        /// <summary>
        /// Task execution status
        /// Enum: Pending, InProgress, Completed
        /// </summary>
        public string[] status { get; set; }

        /// <summary>
        /// Task assignment status
        /// Enum: Unassigned, Assigned
        /// </summary>
        public string assignmentStatus { get; set; }

        /// <summary>
        /// Internal identifier of a task assignee
        /// </summary>
        public string[] assigneeId { get; set; }

        /// <summary>
        /// Task execution status by assignee(-s) specified in assigneeId
        /// Enum: Pending, Completed
        /// </summary>
        public string assigneeStatus { get; set; }

        /// <summary>
        /// Token of the current page. If token is omitted then the first page should be returned
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        /// Number of records to be returned per screen
        /// Maximum: 250
        /// Minimum: 1
        /// Default: 30
        /// </summary>
        public long? recordCount { get; set; }
    }
}