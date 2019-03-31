namespace RingCentral
{
    // Returns the lists of blocked and allowed phone numbers
    public class CallerBlockingSettings
    {
        /// <summary>
        /// Call blocking options: either specific or all calls and faxes
        /// Enum: Specific, All
        /// </summary>
        public string mode;

        /// <summary>
        /// Determines how to handle calls with no caller ID in 'Specific' mode
        /// Enum: BlockCallsAndFaxes, BlockFaxes, Allow
        /// </summary>
        public string noCallerId;

        /// <summary>
        /// Blocking settings for pay phones
        /// Enum: Block, Allow
        /// </summary>
        public string payPhones;

        /// <summary>
        /// List of greetings played for blocked callers
        /// </summary>
        public BlockedCallerGreetingInfo[] greetings;
    }
}