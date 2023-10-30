namespace RingCentral
{
    public class AccountHistorySearchPublicResponse
    {
        /// <summary>
        ///     List of records
        /// </summary>
        public AccountHistoryPublicRecord[] records { get; set; }

        /// <summary>
        /// </summary>
        public AccountHistoryPaging paging { get; set; }
    }
}