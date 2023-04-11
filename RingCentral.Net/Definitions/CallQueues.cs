namespace RingCentral
{
    public class CallQueues
    {
        /// <summary>
        ///     Link to a call queues resource
        ///     Required
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of call queues
        ///     Required
        /// </summary>
        public CallQueueInfo[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}