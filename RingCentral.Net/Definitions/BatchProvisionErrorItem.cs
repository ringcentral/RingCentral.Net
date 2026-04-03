namespace RingCentral
{
    public class BatchProvisionErrorItem
    {
        /// <summary>
        ///     Indicates if the provisioning operation was successful for this item, always `false` in this model
        ///     Required
        /// </summary>
        public bool? successful { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public ApiErrorWithParameter[] errors { get; set; }
    }
}