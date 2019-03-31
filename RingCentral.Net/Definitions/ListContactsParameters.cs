namespace RingCentral
{
    public class ListContactsParameters
    {
        /* If specified, only contacts whose First name or Last name start with the mentioned substring are returned. Case-insensitive */
        public string startsWith;

        /* Sorts results by the specified property */
        public string[] sortBy;

        /* Indicates the page number to retrieve. Only positive number values are accepted */
        // Default: 1
        public long? page;

        /* Indicates the page size (number of items) */
        // Default: 100
        public long? perPage;

        public string[] phoneNumber;
    }
}