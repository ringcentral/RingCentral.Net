namespace RingCentral
{
    /// <summary>
    ///     Cost center information. Applicable if Cost Center feature is enabled. The default is `root` cost center value
    /// </summary>
    public class CostCenterInfo
    {
        /// <summary>
        ///     Internal identifier of a cost center
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Name of a cost center
        /// </summary>
        public string name { get; set; }
    }
}