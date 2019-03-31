namespace RingCentral
{
    public class ContactList
    {
        /// <summary>
        /// List of personal contacts from the extension address book
        /// </summary>
        public PersonalContactResource[] records;

        /// <summary>
        /// Information on navigation
        /// </summary>
        public UserContactsNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// </summary>
        public UserContactsPagingInfo paging;
    }
}