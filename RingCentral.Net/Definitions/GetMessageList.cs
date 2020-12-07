namespace RingCentral
{
    public class GetMessageList
    {
        /// <summary>
        /// Link to the list of user messages
        /// </summary>
        public string uri;

        /// <summary>
        /// List of records with message information
        /// Required
        /// </summary>
        public GetMessageInfoResponse[] records;

        /// <summary>
        /// Required
        /// </summary>
        public MessagingNavigationInfo navigation;

        /// <summary>
        /// Required
        /// </summary>
        public MessagingPagingInfo paging;
    }
}