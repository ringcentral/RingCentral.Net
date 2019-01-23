namespace RingCentral
{
    // Returns the lists of blocked and allowed phone numbers
    public class CallerBlockingSettingsUpdate : Serializable
    {
        // Call blocking options: either specific or all calls and faxes
        // Enum: Specific, All
        public string mode;

        // Determines how to handle calls with no caller ID in 'Specific' mode
        // Enum: BlockCallsAndFaxes, BlockFaxes, Allow
        public string noCallerId;

        // Blocking settings for pay phones
        // Enum: Block, Allow
        public string payPhones;

        // List of greetings played for blocked callers
        public BlockedCallerGreetingInfo[] greetings;
    }
}