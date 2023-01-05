namespace RingCentral
{
    public class PersonalContactResource
    {
        /// <summary>
        ///     Canonical URI of a contact
        ///     Format: uri
        ///     Example:
        ///     https://platform.ringcentral.com/restapi/v1.0/account/230919004/extension/230919004/address-book/contact/623045004
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     This property has a special meaning only on Address Book Sync
        ///     (e.g. a contact can be `Deleted`). For simple contact list reading it
        ///     has always the default value - `Alive`
        ///     Enum: Alive, Deleted, Purged
        /// </summary>
        public string availability { get; set; }

        /// <summary>
        ///     Email of a contact
        ///     Format: email
        ///     Example: charlie.williams@example.com
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///     Internal identifier of availability contact
        ///     Format: int64
        ///     Example: 623045004
        /// </summary>
        public long? id { get; set; }

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
        ///     The contact home page URL
        ///     Format: uri
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
        ///     Third email of a contact
        ///     Format: email
        ///     Example: theboss-example@hotmail.com
        /// </summary>
        public string email3 { get; set; }

        /// <summary>
        ///     Home phone number of a contact in e.164 (with "+") format
        ///     Example: 15551234567
        /// </summary>
        public string homePhone { get; set; }

        /// <summary>
        ///     Second home phone number of a contact in e.164 (with "+") format
        ///     Example: 15551234567
        /// </summary>
        public string homePhone2 { get; set; }

        /// <summary>
        ///     Business phone of the contact in e.164 (with "+") format
        ///     Example: 15551234567
        /// </summary>
        public string businessPhone { get; set; }

        /// <summary>
        ///     Second business phone of a contact in e.164 (with "+") format
        ///     Example: 15551234567
        /// </summary>
        public string businessPhone2 { get; set; }

        /// <summary>
        ///     Mobile phone of a contact in e.164 (with "+") format
        ///     Example: 15551234567
        /// </summary>
        public string mobilePhone { get; set; }

        /// <summary>
        ///     Business fax number of a contact in e.164 (with "+") format
        ///     Example: 15551234567
        /// </summary>
        public string businessFax { get; set; }

        /// <summary>
        ///     Company number of a contact in e.164 (with "+") format
        ///     Example: 15551234567
        /// </summary>
        public string companyPhone { get; set; }

        /// <summary>
        ///     Phone number of a contact assistant in e.164 (with "+") format
        ///     Example: 15551234567
        /// </summary>
        public string assistantPhone { get; set; }

        /// <summary>
        ///     Car phone number of a contact in e.164 (with "+") format
        ///     Example: 15551234567
        /// </summary>
        public string carPhone { get; set; }

        /// <summary>
        ///     Other phone number of a contact in e.164 (with "+") format
        ///     Example: 15551234567
        /// </summary>
        public string otherPhone { get; set; }

        /// <summary>
        ///     Other fax number of a contact in e.164 (with "+") format
        ///     Example: 15551234567
        /// </summary>
        public string otherFax { get; set; }

        /// <summary>
        ///     Callback phone number of a contact in e.164 (with "+") format
        ///     Example: 15551234567
        /// </summary>
        public string callbackPhone { get; set; }

        /// <summary>
        /// </summary>
        public ContactAddressInfo businessAddress { get; set; }

        /// <summary>
        /// </summary>
        public ContactAddressInfo homeAddress { get; set; }

        /// <summary>
        /// </summary>
        public ContactAddressInfo otherAddress { get; set; }

        /// <summary>
        ///     Contact ringtone. Max number of symbols is 64
        /// </summary>
        public string ringtoneIndex { get; set; }
    }
}