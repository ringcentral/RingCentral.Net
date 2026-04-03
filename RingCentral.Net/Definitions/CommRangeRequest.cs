namespace RingCentral
{
    public class CommRangeRequest
    {
        /// <summary>
        ///     Start date-time
        /// </summary>
        public string startDateTime { get; set; }

        /// <summary>
        ///     End date-time
        ///     Required
        /// </summary>
        public string endDateTime { get; set; }
    }
}