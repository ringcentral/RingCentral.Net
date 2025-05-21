namespace RingCentral
{
    public class RecordingInsights
    {
        /// <summary>
        ///     Title of the call
        ///     Required
        ///     Example: Call from 1234567890 to 0987654321
        /// </summary>
        public string title { get; set; }

        /// <summary>
        ///     URI of the call recording
        ///     Example: https://ringsense.ringcentral.com/calls/2e67979e-ff82-4171-ae30-20c0c1f19b27
        /// </summary>
        public string rsRecordUri { get; set; }

        /// <summary>
        ///     Source rc application of the recording
        ///     Required
        ///     Example: pbx
        ///     Enum: pbx, rcv, rcx, connect-and-sell, nice-incontact, ms-teams
        /// </summary>
        public string domain { get; set; }

        /// <summary>
        ///     Recording ID of the domain
        ///     Required
        ///     Example: 4b57_384543
        /// </summary>
        public string sourceRecordId { get; set; }

        /// <summary>
        ///     Session ID of the domain
        ///     Required
        ///     Example: cbac2b78-6f74-4257-8167-dff864de2263!us-10-dca09@us-10
        /// </summary>
        public string sourceSessionId { get; set; }

        /// <summary>
        ///     Optional call direction in case of phone call recording
        ///     Example: Inbound
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string callDirection { get; set; }

        /// <summary>
        ///     Extension id of the call recording owner
        ///     Required
        ///     Example: 123456789
        /// </summary>
        public string ownerExtensionId { get; set; }

        /// <summary>
        ///     Duration of the call recording (in ms)
        ///     Required
        ///     Format: int32
        ///     Example: 112000
        /// </summary>
        public long? recordingDurationMs { get; set; }

        /// <summary>
        ///     Start time of the call recording
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string recordingStartTime { get; set; }

        /// <summary>
        ///     Creation time of the call insights
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Last modified time of the call insights
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     List of the participants in the call
        ///     Required
        /// </summary>
        public object[] speakerInfo { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public AIInsights insights { get; set; }
    }
}