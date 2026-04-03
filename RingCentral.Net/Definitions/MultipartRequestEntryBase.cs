namespace RingCentral
{
    public class MultipartRequestEntryBase
    {
        /// <summary>
        ///     Internal identifier of a resource (required when alternative syntax with '*' is used)
        ///     Example: 1724099032020
        /// </summary>
        public string resourceId { get; set; }
    }
}