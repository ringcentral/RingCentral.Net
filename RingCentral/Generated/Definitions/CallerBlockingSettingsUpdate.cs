using Newtonsoft.Json;

namespace RingCentral
{
    public class CallerBlockingSettingsUpdate : Serializable
    {
        // Call blocking options: either specific or all calls and faxes
        public string mode;
        // Determines how to handle calls with no caller ID in 'Specific' mode
        public string noCallerId;
        // Blocking settings for pay phones
        public string payPhones;
        // List of greetings played for blocked callers
        public BlockedCallerGreetingInfo[] greetings;
    }
}