using Newtonsoft.Json;

namespace RingCentral
{
    public class CallerIdByDevice : Serializable
    {
        public CallerIdDeviceInfo device;
        public CallerIdByDeviceInfo callerId;
    }
}