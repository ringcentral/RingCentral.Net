using System.Threading.Tasks;

namespace RingCentral
{
    public abstract class SdkExtension
    {
        public abstract void Install(RestClient rc);
    }
}