namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation rcwRegListRegistrants
    /// </summary>
    public class RcwRegListRegistrantsParameters
    {
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
        ///     The token indicating the particular page of the result set to be retrieved.
        ///     If omitted the first page will be returned.
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     Indicates if registrant's "questionnaire" should be returned
        /// </summary>
        public bool? includeQuestionnaire { get; set; }
    }
}