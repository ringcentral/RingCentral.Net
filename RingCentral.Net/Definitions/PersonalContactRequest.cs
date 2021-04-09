namespace RingCentral
{
    public class PersonalContactRequest
    {
        /// <summary>
        ///     First name of the contact
        ///     Example: Charlie
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        ///     Last name of the contact
        ///     Example: Williams
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        ///     Middle name of the contact
        ///     Example: J
        /// </summary>
        public string middleName { get; set; }

        /// <summary>
        ///     Nick name of the contact
        ///     Example: The Boss
        /// </summary>
        public string nickName { get; set; }

        /// <summary>
        ///     Company name of the contact
        ///     Example: Example, Inc.
        /// </summary>
        public string company { get; set; }

        /// <summary>
        ///     Job title of the contact
        ///     Example: CEO
        /// </summary>
        public string jobTitle { get; set; }

        /// <summary>
        ///     Email of the contact
        ///     Example: charlie.williams@example.com
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///     2nd email of the contact
        ///     Example: charlie-example@gmail.com
        /// </summary>
        public string email2 { get; set; }

        /// <summary>
        ///     3rd email of the contact
        ///     Example: theboss-example@hotmail.com
        /// </summary>
        public string email3 { get; set; }

        /// <summary>
        ///     Date of birth of the contact
        ///     Format: date-time
        /// </summary>
        public string birthday { get; set; }

        /// <summary>
        ///     The contact home page URL
        ///     Example: http://www.example.com
        /// </summary>
        public string webPage { get; set; }

        /// <summary>
        ///     Notes for the contact
        ///     Example: #1 Customer
        /// </summary>
        public string notes { get; set; }

        /// <summary>
        ///     Home phone number of the contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string homePhone { get; set; }

        /// <summary>
        ///     2nd home phone number of the contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string homePhone2 { get; set; }

        /// <summary>
        ///     Business phone of the contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string businessPhone { get; set; }

        /// <summary>
        ///     2nd business phone of the contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string businessPhone2 { get; set; }

        /// <summary>
        ///     Mobile phone of the contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string mobilePhone { get; set; }

        /// <summary>
        ///     Business fax number of the contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string businessFax { get; set; }

        /// <summary>
        ///     Company number of the contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string companyPhone { get; set; }

        /// <summary>
        ///     Phone number of the contact assistant in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string assistantPhone { get; set; }

        /// <summary>
        ///     Car phone number of the contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string carPhone { get; set; }

        /// <summary>
        ///     Other phone number of the contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string otherPhone { get; set; }

        /// <summary>
        ///     Other fax number of the contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string otherFax { get; set; }

        /// <summary>
        ///     Callback phone number of the contact in e.164 (with "+") format
        ///     Example: +15551234567
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
        ///     Contact ringtone. Max number of symbols is 64
        /// </summary>
        public string ringtoneIndex { get; set; }
    }
}