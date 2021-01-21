namespace RingCentral
{
    // Weekly schedule
    public class WeeklyScheduleInfo
    {
        /// <summary>
        /// Time intervals for a particular day
        /// </summary>
        public TimeInterval[] monday { get; set; }

        /// <summary>
        /// Time intervals for a particular day
        /// </summary>
        public TimeInterval[] tuesday { get; set; }

        /// <summary>
        /// Time intervals for a particular day
        /// </summary>
        public TimeInterval[] wednesday { get; set; }

        /// <summary>
        /// Time intervals for a particular day
        /// </summary>
        public TimeInterval[] thursday { get; set; }

        /// <summary>
        /// Time intervals for a particular day
        /// </summary>
        public TimeInterval[] friday { get; set; }

        /// <summary>
        /// Time intervals for a particular day
        /// </summary>
        public TimeInterval[] saturday { get; set; }

        /// <summary>
        /// Time intervals for a particular day
        /// </summary>
        public TimeInterval[] sunday { get; set; }
    }
}