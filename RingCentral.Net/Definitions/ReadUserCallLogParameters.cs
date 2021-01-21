namespace RingCentral
{
    public class ReadUserCallLogParameters
    {
        /// <summary>
        /// Extension number of a user. If specified, returns call log for a particular extension only
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// If 'True' then calls from/to blocked numbers are returned
        /// Default: true
        /// </summary>
        public bool? showBlocked { get; set; }

        /// <summary>
        /// Phone number of a caller/callee. If specified, returns all calls (both incoming and outcoming) with the phone number specified
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// The direction for the resulting records. If not specified, both inbound and outbound records are returned. Multiple values are accepted
        /// Enum: Inbound, Outbound
        /// </summary>
        public string[] direction { get; set; }

        /// <summary>
        /// Internal identifier of a session
        /// </summary>
        public string sessionId { get; set; }

        /// <summary>
        /// Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted
        /// Enum: Voice, Fax
        /// </summary>
        public string[] type { get; set; }

        /// <summary>
        /// Call transport type. 'PSTN' specifies that a call leg is initiated from the PSTN network provider; 'VoIP' - from an RC phone. By default this filter is disabled
        /// Enum: PSTN, VoIP
        /// </summary>
        public string[] transport { get; set; }

        /// <summary>
        /// View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync
        /// Default: Simple
        /// Enum: Simple, Detailed
        /// </summary>
        public string view { get; set; }

        /// <summary>
        /// **Deprecated**. Supported for compatibility reasons. `True` if only recorded calls are returned. If both `withRecording` and `recordingType` are specified, then `withRecording` is ignored
        /// </summary>
        public bool? withRecording { get; set; }

        /// <summary>
        /// Type of a call recording. If not specified, then calls without recordings are also returned
        /// Enum: Automatic, OnDemand, All
        /// </summary>
        public string recordingType { get; set; }

        /// <summary>
        /// The end datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601] format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
        /// </summary>
        public string dateTo { get; set; }

        /// <summary>
        /// The start datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601] format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are allowed
        /// Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        /// Indicates the page size (number of items)
        /// Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        /// If 'True' then deleted calls are returned
        /// </summary>
        public bool? showDeleted { get; set; }
    }
}