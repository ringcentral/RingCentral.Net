namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readUserCallLog
    /// </summary>
    public class ReadUserCallLogParameters
    {
        /// <summary>
        ///     Short extension number of a user. If specified, returns call log for this particular extension only.
        ///     Cannot be combined with `phoneNumber` filter
        ///     Example: 101
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Phone number of a caller/callee in e.164 format without a '+' sign. If specified, all incoming/outgoing calls
        ///     from/to this phone number are returned.
        ///     Example: 12053320032
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Indicates then calls from/to blocked numbers are returned
        ///     Default: true
        /// </summary>
        public bool? showBlocked { get; set; }

        /// <summary>
        ///     The direction of call records to be included in the result. If omitted, both
        ///     inbound and outbound calls are returned. Multiple values are supported
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string[] direction { get; set; }

        /// <summary>
        ///     Internal identifier of a call session
        /// </summary>
        public string sessionId { get; set; }

        /// <summary>
        ///     The type of call records to be included in the result.
        ///     If omitted, all call types are returned. Multiple values are supported
        ///     Enum: Voice, Fax
        /// </summary>
        public string[] type { get; set; }

        /// <summary>
        ///     The type of call transport. Multiple values are supported. By default this filter is disabled
        ///     Enum: PSTN, VoIP
        /// </summary>
        public string[] transport { get; set; }

        /// <summary>
        ///     Defines the level of details for returned call records
        ///     Default: Simple
        ///     Enum: Simple, Detailed
        /// </summary>
        public string view { get; set; }

        /// <summary>
        ///     Deprecated, replaced with `recordingType` filter, still supported for compatibility reasons.
        ///     Indicates if only recorded calls should be returned.
        ///     If both `withRecording` and `recordingType` parameters are specified, then `withRecording` is ignored'
        /// </summary>
        public bool? withRecording { get; set; }

        /// <summary>
        ///     Indicates that call records with recordings of particular type should be returned.
        ///     If omitted, then calls with and without recordings are returned
        ///     Enum: Automatic, OnDemand, All
        /// </summary>
        public string recordingType { get; set; }

        /// <summary>
        ///     The end of the time range to return call records in ISO 8601 format including timezone,
        ///     for example 2016-03-10T18:07:52.534Z. The default value is current time
        ///     Format: date-time
        /// </summary>
        public string dateTo { get; set; }

        /// <summary>
        ///     The beginning of the time range to return call records in ISO 8601 format including timezone,
        ///     for example 2016-03-10T18:07:52.534Z. The default value is `dateTo` minus 24 hours
        ///     Format: date-time
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        ///     Indicates the page number to retrieve. Only positive number values are allowed
        ///     Minimum: 1
        ///     Format: int32
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Indicates the page size (number of items). The default value is 100.
        ///     The maximum value for `Simple` view is 1000, for `Detailed` view - 250
        ///     Minimum: 1
        ///     Format: int32
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Indicates that deleted calls records should be returned
        /// </summary>
        public bool? showDeleted { get; set; }
    }
}