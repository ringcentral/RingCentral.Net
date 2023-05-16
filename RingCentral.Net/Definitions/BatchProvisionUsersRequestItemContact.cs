namespace RingCentral
{
    public class BatchProvisionUsersRequestItemContact
    {
        /// <summary>
        ///     Given name
        ///     Example: John
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        ///     Family name
        ///     Example: Smith
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        ///     Contact email
        ///     Format: email
        ///     Example: john.smith@acme.com
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Example: +16501234567
        /// </summary>
        public string mobileNumber { get; set; }

        /// <summary>
        ///     Indicates that contact email is enabled as login name for this user.
        ///     Please note that email must be unique in this case.
        ///     Default: true
        /// </summary>
        public bool? emailAsLoginName { get; set; }
    }
}