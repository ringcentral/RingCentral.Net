namespace RingCentral
{
    public class BusinessSiteCollectionResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public RolesBusinessSiteResource[] records { get; set; }
    }
}