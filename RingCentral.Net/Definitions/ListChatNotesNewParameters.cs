namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listChatNotesNew
    /// </summary>
    public class ListChatNotesNewParameters
    {
        /// <summary>
        ///     The end datetime for resulting records in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601)
        ///     format including timezone, e.g. 2019-03-10T18:23:45. The default value is
        ///     Now.
        /// </summary>
        public string creationTimeTo { get; set; }

        /// <summary>
        ///     The start datetime for resulting records in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601)
        ///     format including timezone
        /// </summary>
        public string creationTimeFrom { get; set; }

        /// <summary>
        ///     Internal identifier of the user that created the note. Multiple
        ///     values are supported
        /// </summary>
        public string creatorId { get; set; }

        /// <summary>
        ///     Status of notes to be fetched; if not specified all notes are
        ///     fetched by default.
        ///     Enum: Active, Draft
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Pagination token
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     Max number of notes to be fetched by one request; the value range is 1-250.
        ///     Maximum: 250
        ///     Format: int32
        ///     Default: 30
        /// </summary>
        public long? recordCount { get; set; }
    }
}