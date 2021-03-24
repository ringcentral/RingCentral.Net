namespace RingCentral
{
    public class AuthProfileCheckResource
    {
        /// <summary>
        /// Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public bool? successful { get; set; }

        /// <summary>
        /// </summary>
        public ActivePermissionResource details { get; set; }
    }
}