namespace RingCentral
{
    public class PlayTarget
    {
        /// <summary>
        /// Required
        /// </summary>
        public PlayResource[] resources;

        /// <summary>
        /// Determines command termination condition: specified milliseconds passed since command start.
        /// Required
        /// </summary>
        public string onResult;

        /// <summary>
        /// interrupt or not play media by DTMF.
        /// Default: true
        /// </summary>
        public bool? interruptByDtmf;

        /// <summary>
        /// Controls if file playing can be repeated until stop or interrupt. 0 is for infinite.
        /// Default: 1
        /// </summary>
        public long? repeatCount;
    }
}