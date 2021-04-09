namespace RingCentral
{
    public class CustomFieldResource
    {
        /// <summary>
        ///     Custom field identifier
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Object category to attach custom fields
        ///     Enum: User
        /// </summary>
        public string category { get; set; }

        /// <summary>
        ///     Custom field display name
        /// </summary>
        public string displayName { get; set; }
    }
}