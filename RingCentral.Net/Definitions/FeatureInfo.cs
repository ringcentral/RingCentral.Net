namespace RingCentral
{
    public class FeatureInfo
    {
        /// <summary>
        /// Internal identifier of a feature
        /// </summary>
        public string id;

        /// <summary>
        /// Specifies if the feature is available for the current user according to services enabled for the account, type, entitlements and permissions of the extension. If the authorized user gets features of the other extension, only features that can be delegated are returned (such as configuration by administrators).
        /// </summary>
        public bool? available;

        /// <summary>
        /// </summary>
        public ParamsInfo[] @params;

        /// <summary>
        /// Reason of the feature unavailability. Returned only if `available` is set to 'false'
        /// </summary>
        public ReasonInfo reason;
    }
}