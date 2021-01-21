namespace RingCentral
{
    // Contact resource
    public class AddressBookBulkContactResource
    {
        /// <summary>
        /// Email of a contact
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Notes for a contact
        /// </summary>
        public string notes { get; set; }

        /// <summary>
        /// Company name of a contact
        /// </summary>
        public string company { get; set; }

        /// <summary>
        /// First name of a contact
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        /// Last name of a contact
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        /// Job title of a contact
        /// </summary>
        public string jobTitle { get; set; }

        /// <summary>
        /// Date of birth of a contact
        /// </summary>
        public string birthday { get; set; }

        /// <summary>
        /// Link to a contact home page
        /// </summary>
        public string webPage { get; set; }

        /// <summary>
        /// Middle name of a contact
        /// </summary>
        public string middleName { get; set; }

        /// <summary>
        /// Nick name of a contact
        /// </summary>
        public string nickName { get; set; }

        /// <summary>
        /// Second email of a contact
        /// </summary>
        public string email2 { get; set; }

        /// <summary>
        /// Third email of a contact
        /// </summary>
        public string email3 { get; set; }

        /// <summary>
        /// Home phone number of a contact in e.164 (with "+") format
        /// </summary>
        public string homePhone { get; set; }

        /// <summary>
        /// 2nd home phone number of a contact in e.164 (with "+") format
        /// </summary>
        public string homePhone2 { get; set; }

        /// <summary>
        /// Business phone of a contact in e.164 (with "+") format
        /// </summary>
        public string businessPhone { get; set; }

        /// <summary>
        /// 2nd business phone of a contact in e.164 (with "+") format
        /// </summary>
        public string businessPhone2 { get; set; }

        /// <summary>
        /// Mobile phone of a contact in e.164 (with "+") format
        /// </summary>
        public string mobilePhone { get; set; }

        /// <summary>
        /// Business fax number of a contact in e.164 (with "+") format
        /// </summary>
        public string businessFax { get; set; }

        /// <summary>
        /// Company number of a contact in e.164 (with "+") format
        /// </summary>
        public string companyPhone { get; set; }

        /// <summary>
        /// Phone number of a contact assistant in e.164 (with "+") format
        /// </summary>
        public string assistantPhone { get; set; }

        /// <summary>
        /// Car phone number of a contact in e.164 (with "+") format
        /// </summary>
        public string carPhone { get; set; }

        /// <summary>
        /// Other phone number of a contact in e.164 (with "+") format
        /// </summary>
        public string otherPhone { get; set; }

        /// <summary>
        /// Other fax number of a contact in e.164 (with "+") format
        /// </summary>
        public string otherFax { get; set; }

        /// <summary>
        /// Callback phone number of a contact in e.164 (with "+") format
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