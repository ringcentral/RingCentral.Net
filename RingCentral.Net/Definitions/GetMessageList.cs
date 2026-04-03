namespace RingCentral
{
    public class GetMessageList
    {
        /// <summary>
        ///     Link to a list of user messages
        ///     Format: uri
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