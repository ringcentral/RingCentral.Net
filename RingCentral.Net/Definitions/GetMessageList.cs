namespace RingCentral
{
    public class GetMessageList
    {
        /// <summary>
        ///     Link to the list of user messages
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of records with message information
        ///     Required
        /// </summary>
        public GetMessageInfoResponse[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public MessagingNavigationInfo navigation { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public MessagingPagingInfo paging { get; set; }
    }
}