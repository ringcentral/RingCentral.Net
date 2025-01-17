namespace RingCentral
{
    public class CallMonitoringGroup
    {
        /// <summary>
        ///     Link to a call monitoring group resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a group
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Name of a group
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public CallMonitoringGroupSite site { get; set; }
    }
}