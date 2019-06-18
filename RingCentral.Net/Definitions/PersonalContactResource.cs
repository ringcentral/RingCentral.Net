namespace RingCentral
{
    public class PersonalContactResource
    {
        /// <summary>
        /// Canonical URI of the contact
        /// </summary>
        public string uri;

        /// <summary>
        /// This property has a special meaning only on Address Book Sync (e.g. a contact can be `Deleted`). For simple contact list reading it has always the default value - `Alive`
        /// Enum: Alive, Deleted, Purged
        /// </summary>
        public string availability;

        /// <summary>
        /// Email of the contact
        /// </summary>
        public string email;

        /// <summary>
        /// Internal identifier of the contact
        /// </summary>
        public long? id;

        /// <summary>
        /// Notes for the contact
        /// </summary>
        public string notes;

        /// <summary>
        /// Company name of the contact
        /// </summary>
        public string company;

        /// <summary>
        /// First name of the contact
        /// </summary>
        public string firstName;

        /// <summary>
        /// Last name of the contact
        /// </summary>
        public string lastName;

        /// <summary>
        /// Job title of the contact
        /// </summary>
        public string jobTitle;

        /// <summary>
        /// Date of birth of the contact
        /// </summary>
        public string birthday;

        /// <summary>
        /// The contact home page URL
        /// </summary>
        public string webPage;

        /// <summary>
        /// Middle name of the contact
        /// </summary>
        public string middleName;

        /// <summary>
        /// Nick name of the contact
        /// </summary>
        public string nickName;

        /// <summary>
        /// 2nd email of the contact
        /// </summary>
        public string email2;

        /// <summary>
        /// 3rd email of the contact
        /// </summary>
        public string email3;

        /// <summary>
        /// Home phone number of the contact in e.164 (with "+") format
        /// </summary>
        public string homePhone;

        /// <summary>
        /// 2nd home phone number of the contact in e.164 (with "+") format
        /// </summary>
        public string homePhone2;

        /// <summary>
        /// Business phone of the contact in e.164 (with "+") format
        /// </summary>
        public string businessPhone;

        /// <summary>
        /// 2nd business phone of the contact in e.164 (with "+") format
        /// </summary>
        public string businessPhone2;

        /// <summary>
        /// Mobile phone of the contact in e.164 (with "+") format
        /// </summary>
        public string mobilePhone;

        /// <summary>
        /// Business fax number of the contact in e.164 (with "+") format
        /// </summary>
        public string businessFax;

        /// <summary>
        /// Company number of the contact in e.164 (with "+") format
        /// </summary>
        public string companyPhone;

        /// <summary>
        /// Phone number of the contact assistant in e.164 (with "+") format
        /// </summary>
        public string assistantPhone;

        /// <summary>
        /// Car phone number of the contact in e.164 (with "+") format
        /// </summary>
        public string carPhone;

        /// <summary>
        /// Other phone number of the contact in e.164 (with "+") format
        /// </summary>
        public string otherPhone;

        /// <summary>
        /// Other fax number of the contact in e.164 (with "+") format
        /// </summary>
        public string otherFax;

        /// <summary>
        /// Callback phone number of the contact in e.164 (with "+") format
        /// </summary>
        public string callbackPhone;

        /// <summary>
        /// </summary>
        public ContactAddressInfo businessAddress;

        /// <summary>
        /// </summary>
        public ContactAddressInfo homeAddress;

        /// <summary>
        /// </summary>
        public ContactAddressInfo otherAddress;
    }
}