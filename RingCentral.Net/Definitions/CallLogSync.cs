namespace RingCentral
{
    public class CallLogSync
    {
        /// <summary>
        /// List of call log records with synchronization information. For ISync the total number of returned records is limited to 250; this includes both new records and the old ones, specified by the recordCount parameter
        /// </summary>
        public CallLogRecord[] records;

        /// <summary>
        /// Sync information (type, token and time)
        /// </summary>
        public SyncInfoCallLog syncInfo;
    }
}