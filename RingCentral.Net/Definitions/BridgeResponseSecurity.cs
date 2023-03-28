namespace RingCentral
{
    public class BridgeResponseSecurity
    {
        /// <summary>
        ///     Specifies if a meeting is password protected.
        /// </summary>
        public bool? passwordProtected { get; set; }

        /// <summary>
        /// </summary>
        public BridgeResponseSecurityPassword password { get; set; }

        /// <summary>
        ///     If true, only authenticated users can join to a meeting.
        /// </summary>
        public bool? noGuests { get; set; }

        /// <summary>
        ///     If true, only users have the same account can join to a meeting.
        /// </summary>
        public bool? sameAccount { get; set; }

        /// <summary>
        ///     If true, end to end encryption will be enabled for a meeting.
        /// </summary>
        public bool? e2ee { get; set; }
    }
}