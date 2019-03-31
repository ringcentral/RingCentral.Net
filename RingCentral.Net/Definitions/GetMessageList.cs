namespace RingCentral
{
    public class GetMessageList
    {
        /// <summary>
        /// List of records with message information
        /// Required
        /// </summary>
        public GetMessageInfoResponse[] records;

        /// <summary>
        /// Information on navigation
        /// Required
        /// </summary>
        public MessagingNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// Required
        /// </summary>
        public MessagingPagingInfo paging;
    }
}