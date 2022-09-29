namespace RingCentral
{
    public class TimelineRequest
    {
        /// <summary>
        ///     Required
        /// </summary>
        public Grouping grouping { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public TimeSettings timeSettings { get; set; }

        /// <summary>
        /// </summary>
        public CallFilters callFilters { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public TimelineResponseOptions responseOptions { get; set; }
    }
}