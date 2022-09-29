namespace RingCentral
{
    /// <summary>
    ///     A list of time-value points of call data as per the grouping and filtering options specified in the request
    /// </summary>
    public class TimelineResponseData
    {
        /// <summary>
        ///     The selected grouping option
        ///     Required
        ///     Enum: Company, CompanyNumbers, Users, Queues, IVRs, SharedLines, UserGroups, Sites, Departments
        /// </summary>
        public string groupedBy { get; set; }

        /// <summary>
        ///     List of call data as per the grouping and filtering options specified in the request
        /// </summary>
        public TimelineResponseRecord[] records { get; set; }
    }
}