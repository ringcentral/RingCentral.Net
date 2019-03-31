namespace RingCentral
{
    public class ListLocationsParameters
    {
        /// <summary>
        /// Sorts results by the property specified
        /// Default: City
        /// Enum: Npa, City
        /// </summary>
        public string orderBy;

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
        /// Internal identifier of a state
        /// </summary>
        public string stateId;

        /// <summary>
        /// Specifies if nxx codes are returned
        /// </summary>
        public bool? withNxx;
    }
}