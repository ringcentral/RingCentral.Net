namespace RingCentral
{
    public class GreetingResource
    {
        // Enum: StartRecording, StopRecording, AutomaticRecording
        public string type;

        // 'Default' value specifies that all greetings of that type (in all languages) are default, if at least one greeting (in any language) of the specified type is custom, then 'Custom' value is returned.
        // Enum: Default, Custom
        public string mode;
    }
}