using System.Threading.Tasks;

namespace RingCentral
{
    public abstract class SdkExtension
    {
        public bool enabled = true;
        public abstract Task Install(RestClient rc);
    }
}