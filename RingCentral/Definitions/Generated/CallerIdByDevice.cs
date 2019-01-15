using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallerIdByDevice : Serializable
    {
        public CallerIdDeviceInfo device;
        public CallerIdByDeviceInfo callerId;
    }
}