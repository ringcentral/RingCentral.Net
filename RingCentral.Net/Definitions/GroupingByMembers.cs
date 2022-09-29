namespace RingCentral
{
    /// <summary>
    ///     This grouping allows to specify the `groupByMembers` option. The response data will be grouped by users and will
    ///     only include users that belong to the scope selected in `groupByMembers` field
    /// </summary>
    public class GroupingByMembers
    {
        /// <summary>
        ///     The selected data scope
        ///     Required
        ///     Enum: Department, UserGroup, Queue, Site
        /// </summary>
        public string groupByMembers { get; set; }

        /// <summary>
        ///     This field can be used to further limit the users selection by specifying unique identifiers of corresponding
        ///     entities. For example, providing unique queue ids along with `Queue` in `groupByMembers` field will limit the
        ///     response to users that are queue agents in at least one of these queues
        /// </summary>
        public string[] keys { get; set; }
    }
}