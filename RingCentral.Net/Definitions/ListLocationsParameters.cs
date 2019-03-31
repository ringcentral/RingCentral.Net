namespace RingCentral
{
    public class ListLocationsParameters
    {
        /* Sorts results by the property specified */
        // Default: City
        // Enum: Npa, City
        public string orderBy;

        /* Indicates the page number to retrieve. Only positive number values are accepted */
        // Default: 1
        public long? page;

        /* Indicates the page size (number of items) */
        // Default: 100
        public long? perPage;

        /* Internal identifier of a state */
        public string stateId;

        /* Specifies if nxx codes are returned */
        public bool? withNxx;
    }
}