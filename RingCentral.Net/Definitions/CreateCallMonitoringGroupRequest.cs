namespace RingCentral
{
    public class CreateCallMonitoringGroupRequest
    {
        /// <summary>
        ///     Name of a group
        ///     Required
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public CreateCallMonitoringGroupRequestSite site { get; set; }
    }
}