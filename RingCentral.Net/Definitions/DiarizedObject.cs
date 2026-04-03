namespace RingCentral
{
    public class DiarizedObject
    {
        /// <summary>
        ///     Required
        ///     Format: int32
        ///     Example: 2
        /// </summary>
        public long? speakerCount { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public DiarizeSegment[] utterances { get; set; }
    }
}