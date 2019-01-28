namespace RingCentral
{
    public class CreateSipRegistrationRequest
    {
        // Device unique description
        public DeviceInfoRequest[] device; // Required

        // SIP settings for device
        public SIPInfoRequest[] sipInfo; // Required
    }
}