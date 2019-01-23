namespace RingCentral
{
    public class CreateSipRegistrationRequest : Serializable
    {
        // Device unique description
        public DeviceInfoRequest[] device; // Required

        // SIP settings for device
        public SIPInfoRequest[] sipInfo; // Required
    }
}