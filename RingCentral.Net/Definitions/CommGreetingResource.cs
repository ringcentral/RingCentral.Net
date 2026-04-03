namespace RingCentral
{
    public class CommGreetingResource
    {
        /// <summary>
        ///     Greeting type
        ///     Required
        ///     Enum: Custom, Preset
        /// </summary>
        public string effectiveGreetingType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommGreetingIdResource preset { get; set; }

        /// <summary>
        /// </summary>
        public CommGreetingIdResource custom { get; set; }
    }
}