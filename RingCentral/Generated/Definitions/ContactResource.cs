using Newtonsoft.Json;

namespace RingCentral
{
    public class ContactResource : Serializable
    {
        public AccountResource account;
        public string department;
        public string email;
        public string extensionNumber;
        public string firstName;
        public string id;
        public string lastName;
        public string jobTitle;
        public PhoneNumberResource[] phoneNumbers;
        public AccountDirectoryProfileImageResource profileImage;
        public BusinessSiteResource site;
        public string status;
        public string type;
    }
}