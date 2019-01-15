using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GlipPosts : Serializable
    {
        // List of posts
        public GlipPostInfo[] records; // Required
        public GlipNavigationInfo navigation;
    }
}