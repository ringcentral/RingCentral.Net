namespace RingCentral
{
    public class AccountPhoneNumbers : Serializable
    {
        // List of account phone numbers
        public CompanyPhoneNumberInfo[] records;

        // Information on navigation
        public NavigationInfo navigation;

        // Information on paging
        public PagingInfo paging;
    }
}