namespace RingCentral
{
    public class FeatureInfo
    {
        /// <summary>
        ///     Internal identifier of a feature
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Specifies if the feature is available for the current user according to services enabled for the account, type,
        ///     entitlements and permissions of the extension. If the authorized user gets features of the other extension, only
        ///     features that can be delegated are returned (such as configuration by administrators).
        /// </summary>
        public bool? available { get; set; }

        /// <summary>
        /// </summary>
        public ParamsInfo[] @params { get; set; }

        /// <summary>
        /// </summary>
        public ReasonInfo reason { get; set; }
    }
}