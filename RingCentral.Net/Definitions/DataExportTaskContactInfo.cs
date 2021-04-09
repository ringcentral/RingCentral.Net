namespace RingCentral
{
    // List of users whose data is collected. The following data will be exported: posts, tasks, events, etc. posted by the user(s); posts addressing the user(s) via direct and @Mentions; tasks assigned to the listed user(s). The list of 10 users per request is supported.
    public class DataExportTaskContactInfo
    {
        /// <summary>
        ///     Internal identifier of a contact
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Email address of a contact
        /// </summary>
        public string email { get; set; }
    }
}