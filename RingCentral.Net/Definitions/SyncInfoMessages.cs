namespace RingCentral
{
    public class SyncInfoMessages
    {
        /// <summary>
        /// Type of synchronization
        /// Enum: FSync, ISync
        /// </summary>
        public string syncType;

        /// <summary>
        /// Synchronization token
        /// </summary>
        public string syncToken;

        /// <summary>
        /// Last synchronization datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        public string syncTime;
    }
}