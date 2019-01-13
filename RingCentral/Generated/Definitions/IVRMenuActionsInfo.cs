using Newtonsoft.Json;

namespace RingCentral
{
    public class IVRMenuActionsInfo : Serializable
    {
        // Key. The following values are supported: numeric: '1' to '9' Star Hash NoInput 
        public string input;
        // Internal identifier of an answering rule
        public string action;
        // For 'Connect' or 'Voicemail' actions only. Extension reference
        public IVRMenuExtensionInfo extension;
        // For 'Transfer' action only. PSTN number in E.164 format
        public string phoneNumber;
    }
}