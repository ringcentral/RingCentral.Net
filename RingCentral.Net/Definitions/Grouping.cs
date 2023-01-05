namespace RingCentral
{
    public class Grouping
    {
        /// <summary>
        ///     The selected grouping option
        ///     Enum: Company, CompanyNumbers, Users, Queues, IVRs, SharedLines, UserGroups, Sites, Departments
        /// </summary>
        public string groupBy { get; set; }

        /// <summary>
        ///     This field can be used to further limit the users selection by specifying unique identifiers of corresponding
        ///     entities. For example, providing unique queue ids along with `Queue` in `groupByMembers` field will limit the
        ///     response to users that are queue agents in at least one of these queues
        /// </summary>
        public string[] keys { get; set; }

        /// <summary>
        ///     The selected data scope
        ///     Enum: Department, UserGroup, Queue, Site
        /// </summary>
        public string groupByMembers { get; set; }
    }
}