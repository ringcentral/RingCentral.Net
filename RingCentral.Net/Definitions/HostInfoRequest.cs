namespace RingCentral
{
    // Meeting host information
    public class HostInfoRequest
    {
        /// <summary>
        /// Link to the meeting host resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Internal identifier of an extension which is assigned to be a meeting host. The default value is currently logged-in extension identifier
        /// </summary>
        public string id;
    }
}