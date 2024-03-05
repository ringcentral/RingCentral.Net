namespace RingCentral
{
    public class ImportIdentityRequest
    {
        /// <summary>
        ///     Identifier of the identity on the remote channel.
        ///     Required
        ///     Example: 9680ab94-3b78-495c-bb2c-a969954d8260
        /// </summary>
        public string foreignId { get; set; }

        /// <summary>
        ///     The channel identifier to create the identity for.
        ///     Required
        ///     Example: 541014e17aa58d8ccf000023
        /// </summary>
        public string sourceId { get; set; }

        /// <summary>
        ///     Company.
        ///     Example: Test Company
        /// </summary>
        public string company { get; set; }

        /// <summary>
        ///     FirstName.
        ///     Example: John
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        ///     Gender.
        ///     Example: Woman
        ///     Enum: Man, Woman
        /// </summary>
        public string gender { get; set; }

        /// <summary>
        ///     Phone number.
        ///     Example: +33634231224
        /// </summary>
        public string homePhone { get; set; }

        /// <summary>
        ///     LastName.
        ///     Example: Doe
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        ///     Phone number.
        ///     Example: +33634231224
        /// </summary>
        public string mobilePhone { get; set; }

        /// <summary>
        ///     Screen name of the identity.
        ///     Example: John D.
        /// </summary>
        public string screenName { get; set; }

        /// <summary>
        /// </summary>
        public IdentityExtraValues extraValues { get; set; }

        /// <summary>
        ///     Permit to update an existing identity if set to true.
        ///     false by default.
        ///     Example: true
        /// </summary>
        public bool? upsert { get; set; }
    }
}