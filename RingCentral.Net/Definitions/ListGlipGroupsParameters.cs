namespace RingCentral
{
    public class ListGlipGroupsParameters
    {
        /// <summary>
        /// Type of groups to be fetched (by default all type of groups will be fetched)
        /// Enum: Group, Team, PrivateChat, PersonalChat
        /// </summary>
        public string type;

        /// <summary>
        /// Number of groups to be fetched by one request. The maximum value is 250, by default - 30
        /// Maximum: 250
        /// Default: 30
        /// </summary>
        public long? recordCount;

        /// <summary>
        /// Pagination token.
        /// </summary>
        public string pageToken;
    }
}