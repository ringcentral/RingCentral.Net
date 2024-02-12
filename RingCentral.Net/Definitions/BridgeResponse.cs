namespace RingCentral
{
    public class BridgeResponse
    {
        /// <summary>
        ///     Unique bridge identifier
        ///     Example: iad41-c04-ndb256065cf14ae6a1832389d9c2e
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Custom name of a bridge
        ///     Example: Weekly Meeting with Joseph
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Type of bridge. It specifies bridge life cycle.
        ///     1) Instant - The bridge will be used for a meeting only once immediately after creation. Then it will be deleted.
        ///     2) Scheduled - The bridge will be used for scheduled one or more meetings. If the bridge is not used for a long
        ///     time after the last meeting, then it will be deleted.
        ///     3) PMI - The bridge will contain Personal Meeting Identifier owned by a user. It is the default user bridge.
        ///     Each user may have only one default (PMI) bridge. Such bridge will be deleted only in case the user is deleted
        ///     from the system.
        ///     Example: Instant
        ///     Enum: Instant, Scheduled, PMI
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public User host { get; set; }

        /// <summary>
        /// </summary>
        public BridgePinsWithAliases pins { get; set; }

        /// <summary>
        /// </summary>
        public BridgeResponseSecurity security { get; set; }

        /// <summary>
        /// </summary>
        public BridgePreferences preferences { get; set; }

        /// <summary>
        /// </summary>
        public BridgeDiscovery discovery { get; set; }
    }
}