namespace RingCentral
{
    /// <summary>
    ///     Internal RC "brand" information
    /// </summary>
    public class ServiceInfoBrand
    {
        /// <summary>
        ///     RingCentral brand ID
        ///     Required
        ///     Example: 6699
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     RingCentral brand name
        ///     Required
        ///     Example: Partner 1
        /// </summary>
        public string name { get; set; }
    }
}