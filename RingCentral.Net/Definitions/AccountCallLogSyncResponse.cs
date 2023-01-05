namespace RingCentral
{
    public class AccountCallLogSyncResponse
    {
        /// <summary>
        ///     Link to account call log sync resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of call log records with synchronization information. For 'ISync' the total number of returned records is
        ///     limited to 250; this includes both new records and the old ones, specified by the recordCount parameter
        /// </summary>
        public CompanyCallLogRecord[] records { get; set; }

        /// <summary>
        /// </summary>
        public CallLogSyncInfo syncInfo { get; set; }
    }
}