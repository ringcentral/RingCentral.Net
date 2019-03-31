namespace RingCentral
{
    public class LanguageList
    {
        /* Canonical URI of the language list resource */
        public string uri;

        /* Language data */
        public LanguageInfo[] records;

        /* Information on navigation */
        public ProvisioningNavigationInfo navigation;

        /* Information on paging */
        public ProvisioningPagingInfo paging;
    }
}