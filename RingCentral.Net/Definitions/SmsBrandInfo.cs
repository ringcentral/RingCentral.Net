namespace RingCentral
{
    public class SmsBrandInfo
    {
        /// <summary>
        ///     Identifier of the associated TCR brand
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Status of the associated TCR campaign
        ///     Enum: Created, Submitted, Confirmed, SubmitFailed, UpdateRequested, DeleteRequested, CampaignSuspended,
        ///     CampaignExpired, Draft, PreVetFailed, Unconfirmed
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public ApiError[] errors { get; set; }
    }
}