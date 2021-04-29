namespace RingCentral
{
    // Query parameters for operation listContacts
    public class ListContactsParameters
    {
        /// <summary>
        ///     If specified, only contacts whose First name or Last name start with the mentioned substring are returned. Case-insensitive
        /// </summary>
        public string startsWith { get; set; }

        /// <summary>
        ///     Sorts results by the specified property
        ///     Enum: FirstName, LastName, Company
        /// </summary>
        public string[] sortBy { get; set; }

        /// <summary>
        ///     Indicates the page number to retrieve. Only positive number values are accepted
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Indicates the page size (number of items)
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        /// </summary>
        public string[] phoneNumber { get; set; }
    }
}