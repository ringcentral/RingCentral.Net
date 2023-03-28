namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listVideoMeetings
    /// </summary>
    public class ListVideoMeetingsParameters
    {
        /// <summary>
        ///     Search text
        /// </summary>
        public string text { get; set; }

        /// <summary>
        ///     Token to get the next page
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     Number of records returned
        ///     Format: int32
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Type of returned data
        ///     Enum: All, My, Deleted, Shared
        /// </summary>
        public string type { get; set; }
    }
}