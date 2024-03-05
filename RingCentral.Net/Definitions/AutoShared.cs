namespace RingCentral
{
    /// <summary>
    ///     Controls whether recording can be auto shared
    /// </summary>
    public class AutoShared
    {
        /// <summary>
        ///     Controls whether preference is enabled
        ///     Example: true
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Describes whether preference is locked on Service Web
        /// </summary>
        public bool? locked { get; set; }
    }
}