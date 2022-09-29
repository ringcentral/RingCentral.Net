namespace RingCentral
{
    /// <summary>
    ///     Aggregation result
    /// </summary>
    public class AggregationResponseData
    {
        /// <summary>
        ///     The selected grouping option
        ///     Required
        ///     Enum: Company, CompanyNumbers, Users, Queues, IVRs, SharedLines, UserGroups, Sites, Departments
        /// </summary>
        public string groupedBy { get; set; }

        /// <summary>
        ///     A list of call aggregations as per the grouping and filtering options specified in the request
        /// </summary>
        public AggregationResponseRecord[] records { get; set; }
    }
}