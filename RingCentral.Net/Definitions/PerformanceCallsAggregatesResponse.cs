using System.Collections.Generic;

namespace RingCentral
{
    public class PerformanceCallsAggregatesResponse
    {
        /// <summary>
        ///     Required
        /// </summary>
        public Dictionary<string, PerformanceCallsData> data { get; set; }
    }
}