using Newtonsoft.Json;

namespace RingCentral
{
    public class GlipPosts : Serializable
    {
        // List of posts
        public GlipPostInfo[] records;
        public GlipNavigationInfo navigation;
    }
}