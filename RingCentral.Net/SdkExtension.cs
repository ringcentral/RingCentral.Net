using System.Threading.Tasks;

namespace RingCentral
{
    public abstract class SdkExtension
    {
        public bool enabled = true;
        public abstract void Install(RestClient rc);
    }
}