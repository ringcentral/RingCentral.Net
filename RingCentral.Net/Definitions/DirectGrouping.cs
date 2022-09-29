namespace RingCentral
{
    /// <summary>
    ///     This grouping allows to specify the `groupBy` option by which the data in the response will be grouped
    /// </summary>
    public class DirectGrouping
    {
        /// <summary>
        ///     The selected grouping option
        ///     Required
        ///     Enum: Company, CompanyNumbers, Users, Queues, IVRs, SharedLines, UserGroups, Sites, Departments
        /// </summary>
        public string groupBy { get; set; }

        /// <summary>
        ///     This field can be used to specify unique identifiers of entities selected in `groupBy` field. The response data
        ///     will be limited to these entities only
        /// </summary>
        public string[] keys { get; set; }
    }
}