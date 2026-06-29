namespace RingCentral
{
    public class ThreadSyncList
    {
        /// <summary>
        ///     Required
        /// </summary>
        public MessageThread[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public SyncInfoModel syncInfo { get; set; }
    }
}