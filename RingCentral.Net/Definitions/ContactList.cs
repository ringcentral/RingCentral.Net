namespace RingCentral
{
    public class ContactList
    {
        /// <summary>
        ///     Link to the list of user personal contacts
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of personal contacts from the extension address book
        /// </summary>
        public PersonalContactResource[] records { get; set; }

        /// <summary>
        /// </summary>
        public UserContactsNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public UserContactsPagingInfo paging { get; set; }

        /// <summary>
        /// </summary>
        public UserContactsGroupsInfo groups { get; set; }
    }
}