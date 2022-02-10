namespace RingCentral
{
    /// <summary>
    ///     Returned if *Glip* feature is switched on
    /// </summary>
    public class UnifiedPresenceGlip
    {
        /// <summary>
        ///     Glip connection status calculated from all user's apps. Returned always for the requester's extension; returned for
        ///     another users if their glip visibility is set to 'Visible'
        ///     Enum: Offline, Online
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Visibility setting allowing other users to see the user's Glip presence status; returned only for requester's
        ///     extension
        ///     Enum: Visible, Invisible
        /// </summary>
        public string visibility { get; set; }

        /// <summary>
        ///     Shows whether user wants to receive Glip notifications or not.
        ///     Enum: Available, DND
        /// </summary>
        public string availability { get; set; }
    }
}