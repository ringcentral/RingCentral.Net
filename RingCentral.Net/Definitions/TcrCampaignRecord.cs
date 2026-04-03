namespace RingCentral
{
    public class TcrCampaignRecord
    {
        /// <summary>
        ///     Identifier of a TCR campaign
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Name of a TCR campaign
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Enum: Created, Submitted, Confirmed, SubmitFailed, UpdateRequested, DeleteRequested, CampaignSuspended, CampaignExpired, Draft, PreventFailed, Unconfirmed
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Registration time
        ///     Format: date-time
        /// </summary>
        public string registrationTime { get; set; }

        /// <summary>
        ///     External ID
        /// </summary>
        public string externalId { get; set; }

        /// <summary>
        ///     Brand info
        /// </summary>
        public TcrCampaignRecordBrand brand { get; set; }

        /// <summary>
        ///     Enum: LowVolume, StandardVolume
        /// </summary>
        public string registrationTier { get; set; }

        /// <summary>
        ///     Enum: AccountNotification, ConversationsInternal, ConversationsExternal, CustomerCare, DeliveryNotification, FraudAlert, HigherEducation, K12Education, MachineToMachine, Marketing, Mixed, PollingVoting, PublicServiceAnnouncement, SecurityAlert, Unknown
        /// </summary>
        public string[] useCases { get; set; }

        /// <summary>
        /// </summary>
        public ApiErrorWithParameter[] errors { get; set; }
    }
}