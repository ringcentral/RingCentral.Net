namespace RingCentral
{
    public class GetStateListResponse
    {
        /// <summary>
        ///     Link to a states list resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of states
        /// </summary>
        public GetStateInfoResponse[] records { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}