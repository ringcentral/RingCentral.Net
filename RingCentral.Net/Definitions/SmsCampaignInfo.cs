namespace RingCentral
{
    public class SmsCampaignInfo
    {
        /// <summary>
        ///     Identifier of the associated TCR campaign
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Status of the associated TCR campaign
        ///     Enum: Created, Submitted, Confirmed, SubmitFailed, UpdateRequested, DeleteRequested, CampaignSuspended,
        ///     CampaignExpired, Draft, PreVetFailed, Unconfirmed
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Use case of the associated TCR campaign
        /// </summary>
        public string registrationTier { get; set; }

        /// <summary>
        ///     List of sub use cases of the associated TCR campaign
        /// </summary>
        public string[] useCases { get; set; }

        /// <summary>
        /// </summary>
        public ApiError[] errors { get; set; }
    }
}