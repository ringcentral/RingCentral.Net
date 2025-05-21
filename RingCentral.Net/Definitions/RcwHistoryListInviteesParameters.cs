namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation rcwHistoryListInvitees
    /// </summary>
    public class RcwHistoryListInviteesParameters
    {
        /// <summary>
        ///     The role of the participant.
        ///     Enum: Panelist, CoHost, Host, Attendee
        /// </summary>
        public string[] role { get; set; }

        /// <summary>
        ///     The original role of the invitee/participant.
        ///     Enum: Panelist, CoHost, Host, Attendee
        /// </summary>
        public string[] originalRole { get; set; }

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

        /// <summary>
        ///     The token indicating the particular page of the result set to be retrieved.
        ///     If omitted the first page will be returned.
        /// </summary>
        public string pageToken { get; set; }
    }
}