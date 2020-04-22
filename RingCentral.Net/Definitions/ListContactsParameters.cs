namespace RingCentral
{
    public class ListContactsParameters
    {
        /// <summary>
        /// If specified, only contacts whose First name or Last name start with the mentioned substring are returned. Case-insensitive
        /// </summary>
        public string startsWith;

        /// <summary>
        /// Sorts results by the specified property
        /// Enum: FirstName, LastName, Company
        /// </summary>
        public string[] sortBy;

        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are accepted
        /// Default: 1
        /// </summary>
        public long? page;

        /// <summary>
        /// Indicates the page size (number of items)
        /// Default: 100
        /// </summary>
        public long? perPage;

        /// <summary>
        /// </summary>
        public string[] phoneNumber;
    }
}