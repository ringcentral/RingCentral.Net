namespace RingCentral
{
    public class PersonalContactRequest
    {
        /// <summary>
        /// First name of the contact
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        /// Last name of the contact
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        /// Middle name of the contact
        /// </summary>
        public string middleName { get; set; }

        /// <summary>
        /// Nick name of the contact
        /// </summary>
        public string nickName { get; set; }

        /// <summary>
        /// Company name of the contact
        /// </summary>
        public string company { get; set; }

        /// <summary>
        /// Job title of the contact
        /// </summary>
        public string jobTitle { get; set; }

        /// <summary>
        /// Email of the contact
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 2nd email of the contact
        /// </summary>
        public string email2 { get; set; }

        /// <summary>
        /// 3rd email of the contact
        /// </summary>
        public string email3 { get; set; }

        /// <summary>
        /// Date of birth of the contact
        /// </summary>
        public string birthday { get; set; }

        /// <summary>
        /// The contact home page URL
        /// </summary>
        public string webPage { get; set; }

        /// <summary>
        /// Notes for the contact
        /// </summary>
        public string notes { get; set; }

        /// <summary>
        /// Home phone number of the contact in e.164 (with "+") format
        /// </summary>
        public string homePhone { get; set; }

        /// <summary>
        /// 2nd home phone number of the contact in e.164 (with "+") format
        /// </summary>
        public string homePhone2 { get; set; }

        /// <summary>
        /// Business phone of the contact in e.164 (with "+") format
        /// </summary>
        public string businessPhone { get; set; }

        /// <summary>
        /// 2nd business phone of the contact in e.164 (with "+") format
        /// </summary>
        public string businessPhone2 { get; set; }

        /// <summary>
        /// Mobile phone of the contact in e.164 (with "+") format
        /// </summary>
        public string mobilePhone { get; set; }

        /// <summary>
        /// Business fax number of the contact in e.164 (with "+") format
        /// </summary>
        public string businessFax { get; set; }

        /// <summary>
        /// Company number of the contact in e.164 (with "+") format
        /// </summary>
        public string companyPhone { get; set; }

        /// <summary>
        /// Phone number of the contact assistant in e.164 (with "+") format
        /// </summary>
        public string assistantPhone { get; set; }

        /// <summary>
        /// Car phone number of the contact in e.164 (with "+") format
        /// </summary>
        public string carPhone { get; set; }

        /// <summary>
        /// Other phone number of the contact in e.164 (with "+") format
        /// </summary>
        public string otherPhone { get; set; }

        /// <summary>
        /// Other fax number of the contact in e.164 (with "+") format
        /// </summary>
        public string otherFax { get; set; }

        /// <summary>
        /// Callback phone number of the contact in e.164 (with "+") format
        /// </summary>
        public string callbackPhone { get; set; }

        /// <summary>
        /// </summary>
        public ContactAddressInfo homeAddress { get; set; }

        /// <summary>
        /// </summary>
        public ContactAddressInfo businessAddress { get; set; }

        /// <summary>
        /// </summary>
        public ContactAddressInfo otherAddress { get; set; }

        /// <summary>
        /// Contact ringtone. Max number of symbols is 64
        /// </summary>
        public string ringtoneIndex { get; set; }
    }
}