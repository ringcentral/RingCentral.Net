namespace RingCentral
{
    public class ThreadEntriesSyncList
    {
        /// <summary>
        ///     Required
        /// </summary>
        public ThreadEntrySyncItem[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public SyncInfoModel syncInfo { get; set; }
    }
}