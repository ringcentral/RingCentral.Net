using Newtonsoft.Json;

namespace RingCentral
{
    public class CustomGreetingRequest : Serializable
    {
        // Type of a greeting, specifying the case when the greeting is played.
        public string type;
        // Information on an answering rule that the greeting is applied to
        public CustomGreetingAnsweringRuleInfoRequest answeringRule;
    }
}