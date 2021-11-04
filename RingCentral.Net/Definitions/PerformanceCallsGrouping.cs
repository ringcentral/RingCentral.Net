namespace RingCentral
{
    // Grouping options resource defining the parameters by which the report call data will be grouped. If not specified then the whole company data will be returned.
    public class PerformanceCallsGrouping
    {
        /// <summary>
        ///     Specifies parameters by which the response should be grouped
        ///     Required
        ///     Enum: CompanyNumbers, Users, Queues, IVRs, UserGroups, Sites, Departments, DepartmentMembers, UserGroupMembers,
        ///     QueueAgents, SiteMembers
        /// </summary>
        public string groupBy { get; set; }

        /// <summary>
        ///     Internal identifiers of groups for 'groupBy' types. Required for 'DepartmentMembers', 'UserGroupMembers',
        ///     'QueueAgents' and 'SiteMembers' grouping values.
        /// </summary>
        public string[] ids { get; set; }
    }
}