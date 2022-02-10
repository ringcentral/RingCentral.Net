namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listGlipTeams
    /// </summary>
    public class ListGlipTeamsParameters
    {
        /// <summary>
        ///     Number of teams to be fetched by one request. The maximum value is 250, by default - 30
        ///     Maximum: 250
        ///     Default: 30
        /// </summary>
        public long? recordCount { get; set; }

        /// <summary>
        ///     Pagination token.
        /// </summary>
        public string pageToken { get; set; }
    }
}