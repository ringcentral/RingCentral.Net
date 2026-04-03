namespace RingCentral
{
    public class AddressBookBulkContactResource
    {
        /// <summary>
        ///     Email of a contact
        ///     Format: email
        ///     Example: charlie.williams@example.com
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///     Notes for a contact
        ///     Example: #1 Customer
        /// </summary>
        public string notes { get; set; }

        /// <summary>
        ///     Company name of a contact
        ///     Example: Example, Inc.
        /// </summary>
        public string company { get; set; }

        /// <summary>
        ///     First name of a contact
        ///     Example: Charlie
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        ///     Last name of a contact
        ///     Example: Williams
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        ///     Job title of a contact
        ///     Example: CEO
        /// </summary>
        public string jobTitle { get; set; }

        /// <summary>
        ///     Date of birth of a contact
        ///     Format: date-time
        /// </summary>
        public string birthday { get; set; }

        /// <summary>
        ///     Link to a contact home page
        ///     Example: http://www.example.com
        /// </summary>
        public string webPage { get; set; }

        /// <summary>
        ///     Middle name of a contact
        ///     Example: J
        /// </summary>
        public string middleName { get; set; }

        /// <summary>
        ///     Nick name of a contact
        ///     Example: The Boss
        /// </summary>
        public string nickName { get; set; }

        /// <summary>
        ///     Second email of a contact
        ///     Format: email
        ///     Example: charlie-example@gmail.com
        /// </summary>
        public string email2 { get; set; }

        /// <summary>
        ///     Third email of the contact
        ///     Format: email
        ///     Example: theboss-example@hotmail.com
        /// </summary>
        public string email3 { get; set; }

        /// <summary>
        ///     Home phone number of a contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string homePhone { get; set; }

        /// <summary>
        ///     Second home phone number of a contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string homePhone2 { get; set; }

        /// <summary>
        ///     Business phone of a contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string businessPhone { get; set; }

        /// <summary>
        ///     Second business phone of a contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string businessPhone2 { get; set; }

        /// <summary>
        ///     Mobile phone of the contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string mobilePhone { get; set; }

        /// <summary>
        ///     Business fax number of a contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string businessFax { get; set; }

        /// <summary>
        ///     Company number of a contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string companyPhone { get; set; }

        /// <summary>
        ///     Phone number of a contact assistant in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string assistantPhone { get; set; }

        /// <summary>
        ///     Car phone number of a contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string carPhone { get; set; }

        /// <summary>
        ///     Other phone number of a contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string otherPhone { get; set; }

        /// <summary>
        ///     Other fax number of a contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string otherFax { get; set; }

        /// <summary>
        ///     Callback phone number of a contact in e.164 (with "+") format
        ///     Example: +15551234567
        /// </summary>
        public string callbackPhone { get; set; }

        /// <summary>
        /// </summary>
        public AddressBookBulkContactAddressInfo businessAddress { get; set; }

        /// <summary>
        /// </summary>
        public AddressBookBulkContactAddressInfo homeAddress { get; set; }

        /// <summary>
        /// </summary>
        public AddressBookBulkContactAddressInfo otherAddress { get; set; }
    }
}