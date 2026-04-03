namespace RingCentral
{
    public class CallQueueMembers
    {
        /// <summary>
        ///     Link to a call queue members resource
        ///     Required
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of call queue members
        ///     Required
        /// </summary>
        public CallQueueMemberInfo[] records { get; set; }

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