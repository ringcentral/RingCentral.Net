namespace RingCentral
{
    public class CommRangeResource
    {
        /// <summary>
        ///     Start date-time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string startDateTime { get; set; }

        /// <summary>
        ///     End date-time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string endDateTime { get; set; }
    }
}