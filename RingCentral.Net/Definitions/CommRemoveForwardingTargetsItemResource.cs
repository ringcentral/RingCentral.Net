namespace RingCentral
{
    public class CommRemoveForwardingTargetsItemResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public bool? bulkItemSuccessful { get; set; }

        /// <summary>
        /// </summary>
        public ApiError[] bulkItemErrors { get; set; }

        /// <summary>
        ///     Ring target
        ///     Required
        /// </summary>
        public CommRemoveForwardingTargetsItemResourceBulkItem bulkItem { get; set; }
    }
}