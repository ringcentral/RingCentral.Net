namespace RingCentral
{
    public class ListCompanyAnsweringRulesParameters
    {
        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are accepted
        /// Default: 1
        /// </summary>
        public long? page;

        /// <summary>
        /// Indicates the page size (number of items per page)
        /// Default: 100
        /// </summary>
        public long? perPage;
    }
}