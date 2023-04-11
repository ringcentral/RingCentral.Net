namespace RingCentral
{
    public class WcsSessionBaseModel
    {
        /// <summary>
        ///     Session scheduled start time.
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string scheduledStartTime { get; set; }

        /// <summary>
        ///     The duration of the Session in seconds.
        ///     Required
        ///     Maximum: 43200
        ///     Minimum: 30
        ///     Format: int32
        ///     Example: 1800
        /// </summary>
        public long? scheduledDuration { get; set; }

        /// <summary>
        ///     IANA-compatible time zone name (see https://www.iana.org/time-zones).
        ///     Required
        ///     Example: America/New_York
        /// </summary>
        public string timeZone { get; set; }

        /// <summary>
        ///     Session locale code. Can't be blank or null
        ///     Example: en-US
        /// </summary>
        public string localeCode { get; set; }

        /// <summary>
        ///     The time offset (positive, in seconds) indicating how much in advance
        ///     (comparing to "scheduledStartTime") panel members should join for the pre-webinar team sync
        ///     Format: int32
        ///     Example: 900
        /// </summary>
        public long? panelJoinTimeOffset { get; set; }

        /// <summary>
        ///     Session title. Can be left blank - then Webinar title should be used for presentation.
        ///     Example: Live Broadcasting US
        /// </summary>
        public string title { get; set; }

        /// <summary>
        ///     User-friendly description of the Session. Can be left blank - then Webinar title should be used for presentation.
        ///     Example: Live session for US-based participants
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     Session status from Configuration service
        ///     Example: Finished
        ///     Enum: Scheduled, Active, Finished
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     The URI to join the webinar as a host
        ///     Format: uri
        ///     Example: https://v.ringcentral.com/w/join/de7yd8ew7yfsdfjh899843rgj
        /// </summary>
        public string hostJoinUri { get; set; }
    }
}