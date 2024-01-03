namespace RingCentral
{
    public class DefaultUserRole
    {
        /// <summary>
        ///     Link to a default role resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a default role
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Custom name of a default role
        ///     Example: My Custom User Role
        /// </summary>
        public string displayName { get; set; }
    }
}