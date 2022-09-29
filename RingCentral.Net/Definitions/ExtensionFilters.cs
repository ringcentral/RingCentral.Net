namespace RingCentral
{
    /// <summary>
    ///     Specifies filtering based on extension ids
    /// </summary>
    public class ExtensionFilters
    {
        /// <summary>
        ///     List of extension ids to match against incoming calls, joined via OR condition. Only applicable for
        ///     `groupByMembers` options and Users, IVRs, SharedLines and Queues in `groupBy`
        /// </summary>
        public string[] fromIds { get; set; }

        /// <summary>
        ///     List of extension ids to match against outgoing calls, joined via OR condition. Limited to the extension id that
        ///     first accepted the call. Only applicable for `groupByMembers` options and Users, IVRs and SharedLines in `groupBy`
        /// </summary>
        public string[] toIds { get; set; }
    }
}