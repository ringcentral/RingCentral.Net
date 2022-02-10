namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readUserFeatures
    /// </summary>
    public class ReadUserFeaturesParameters
    {
        /// <summary>
        /// </summary>
        public bool? availableOnly { get; set; }

        /// <summary>
        /// </summary>
        public string[] featureId { get; set; }
    }
}