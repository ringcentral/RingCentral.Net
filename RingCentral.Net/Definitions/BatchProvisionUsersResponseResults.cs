namespace RingCentral
{
    public class BatchProvisionUsersResponseResults
    {
        /// <summary>
        ///     Indicates if the provisioning operation was successful for this item, always `false` in this model
        /// </summary>
        public bool? successful { get; set; }

        /// <summary>
        /// </summary>
        public BatchProvisionUsersResponseResultsExtension extension { get; set; }

        /// <summary>
        /// </summary>
        public ApiErrorWithParameter[] errors { get; set; }
    }
}