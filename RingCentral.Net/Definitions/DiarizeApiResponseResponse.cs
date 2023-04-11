namespace RingCentral
{
    public class DiarizeApiResponseResponse
    {
        /// <summary>
        ///     Format: int32
        ///     Example: 3
        /// </summary>
        public long? speakerCount { get; set; }

        /// <summary>
        /// </summary>
        public DiarizeSegment[] utterances { get; set; }
    }
}