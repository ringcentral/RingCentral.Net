namespace RingCentral
{
    public class UserInfoResource
    {
        /// <summary>
        ///     Subject - the End-User internal identifier. Contains RingCentral user (extension) ID
        ///     Required
        ///     Example: 987654321
        /// </summary>
        public string sub { get; set; }

        /// <summary>
        ///     End-User's preferred e-mail address
        ///     Format: email
        ///     Example: john.doe@acme.com
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///     Indicates if the End-User's e-mail address has been verified
        /// </summary>
        public bool? email_verified { get; set; }

        /// <summary>
        ///     The End-User's company account identifier. Contains RingCentral account ID
        /// </summary>
        public string account_id { get; set; }

        /// <summary>
        ///     The last name of the End-User
        /// </summary>
        public string family_name { get; set; }

        /// <summary>
        ///     The first name of the End-User
        /// </summary>
        public string given_name { get; set; }
    }
}