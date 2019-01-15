using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class DeviceUpdatePhoneLinesInfo : Serializable
    {
        // Information on phone lines added to a device
        public UpdateDevicePhoneInfo[] phoneLines;
    }
}