namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readExtensionFeatures
    /// </summary>
    public class ReadExtensionFeaturesParameters
    {
        /// <summary>
        ///     Allows to filter features by availability for an extension
        /// </summary>
        public bool? availableOnly { get; set; }

        /// <summary>
        ///     Internal identifier(s) of the feature(s)
        /// </summary>
        public string[] featureId { get; set; }
    }
}