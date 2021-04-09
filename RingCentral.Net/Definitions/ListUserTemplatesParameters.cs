namespace RingCentral
{
    // Query parameters for operation listUserTemplates
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