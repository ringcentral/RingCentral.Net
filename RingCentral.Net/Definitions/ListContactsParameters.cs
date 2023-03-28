namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listContacts
    /// </summary>
    public class ListContactsParameters
    {
        /// <summary>
        ///     If specified, only contacts which 'First name' or 'Last name' start
        ///     with the mentioned substring will be returned. Case-insensitive
        /// </summary>
        public string startsWith { get; set; }

        /// <summary>
        ///     Sorts results by the specified property
        ///     Enum: FirstName, LastName, Company
        /// </summary>
        public string[] sortBy { get; set; }

        /// <summary>
        ///     The result set page number (1-indexed) to return
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 1
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     The number of items per page. If provided value in the request
        ///     is greater than a maximum, the maximum value is applied
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 100
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Phone number in e.164 format
        /// </summary>
        public string[] phoneNumber { get; set; }
    }
}