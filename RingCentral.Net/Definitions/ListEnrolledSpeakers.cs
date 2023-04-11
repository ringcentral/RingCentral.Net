namespace RingCentral
{
    public class ListEnrolledSpeakers
    {
        /// <summary>
        ///     Required
        /// </summary>
        public PagingSchema paging { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public EnrollmentStatus[] records { get; set; }
    }
}