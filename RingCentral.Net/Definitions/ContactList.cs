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
        /// </summary>
        public UserContactsNavigationInfo navigation;

        /// <summary>
        /// </summary>
        public UserContactsPagingInfo paging;

        /// <summary>
        /// </summary>
        public UserContactsGroupsInfo groups;
    }
}