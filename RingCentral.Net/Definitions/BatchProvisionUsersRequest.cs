namespace RingCentral
{
    /// <summary>
    ///     Describes request for user extension provisioning
    /// </summary>
    public class BatchProvisionUsersRequest
    {
        /// <summary>
        ///     Required
        /// </summary>
        public BatchProvisionUsersRequestItem[] records { get; set; }
    }
}