namespace RingCentral
{
    public class AuthProfileResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public ActivePermissionResource[] permissions { get; set; }
    }
}