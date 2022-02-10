namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listUserTemplates
    /// </summary>
    public class ListUserTemplatesParameters
    {
        /// <summary>
        ///     Enum: UserSettings, CallHandling
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public string page { get; set; }

        /// <summary>
        /// </summary>
        public string perPage { get; set; }
    }
}