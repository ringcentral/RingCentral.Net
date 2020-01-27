namespace RingCentral
{
    public class ContactList
    {
        /// <summary>
        /// link to the list of user personal contacts
        /// </summary>
        public string uri;

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

        /// <summary>
        /// Information on address book groups
        /// </summary>
        public UserContactsGroupsInfo groups;
    }
}