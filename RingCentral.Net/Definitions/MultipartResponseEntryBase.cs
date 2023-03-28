namespace RingCentral
{
    public class MultipartResponseEntryBase
    {
        /// <summary>
        ///     Internal identifier of a resource
        ///     Required
        ///     Example: 1724099032020
        /// </summary>
        public string resourceId { get; set; }

        /// <summary>
        ///     HTTP status code of an operation on given resource
        ///     Required
        ///     Format: int32
        ///     Example: 200
        /// </summary>
        public long? status { get; set; }
    }
}