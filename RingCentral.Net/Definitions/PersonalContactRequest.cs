namespace RingCentral
{
    public class PersonalContactRequest
    {
        /// <summary>
        /// First name of the contact
        /// </summary>
        public string firstName;

        /// <summary>
        /// Last name of the contact
        /// </summary>
        public string lastName;

        /// <summary>
        /// Middle name of the contact
        /// </summary>
        public string middleName;

        /// <summary>
        /// Nick name of the contact
        /// </summary>
        public string nickName;

        /// <summary>
        /// Company name of the contact
        /// </summary>
        public string company;

        /// <summary>
        /// Job title of the contact
        /// </summary>
        public string jobTitle;

        /// <summary>
        /// Email of the contact
        /// </summary>
        public string email;

        /// <summary>
        /// 2nd email of the contact
        /// </summary>
        public string email2;

        /// <summary>
        /// 3rd email of the contact
        /// </summary>
        public string email3;

        /// <summary>
        /// Date of birth of the contact
        /// </summary>
        public string birthday;

        /// <summary>
        /// The contact home page URL
        /// </summary>
        public string webPage;

        /// <summary>
        /// Notes for the contact
        /// </summary>
        public string notes;

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
        public ContactAddressInfo homeAddress;

        /// <summary>
        /// </summary>
        public ContactAddressInfo businessAddress;

        /// <summary>
        /// </summary>
        public ContactAddressInfo otherAddress;

        /// <summary>
        /// Contact ringtone. Max number of symbols is 64
        /// </summary>
        public string ringtoneIndex;
    }
}