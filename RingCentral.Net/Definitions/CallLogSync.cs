namespace RingCentral
{
    public class CallLogSync
    {
        /// <summary>
        /// Link to the list of call log records with sync information
        /// </summary>
        public string uri;

        /// <summary>
        /// List of call log records with synchronization information. For ISync the total number of returned records is limited to 250; this includes both new records and the old ones, specified by the recordCount parameter
        /// </summary>
        public UserCallLogRecord[] records;

        /// <summary>
        /// </summary>
        public SyncInfoCallLog syncInfo;
    }
}