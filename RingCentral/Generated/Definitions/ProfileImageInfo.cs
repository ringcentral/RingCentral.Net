using Newtonsoft.Json;

namespace RingCentral
{
    public class ProfileImageInfo : Serializable
    {
        // Link to a profile image. If an image is not uploaded for an extension, only uri is returned
        public string uri;
        // Identifier of an image
        public string etag;
        // The datetime when an image was last updated in ISO 8601 format, for example 2016-03-10T18:07:52.534Z
        public string lastModified;
        // The type of an image
        public string contentType;
        // List of URIs to profile images in different dimensions
        public ProfileImageInfoURI[] scales;
    }
}