namespace RingCentral
{
    public class CustomFieldCreateRequest
    {
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