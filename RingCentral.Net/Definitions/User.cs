namespace RingCentral
{
    public class User
    {
        /// <summary>
        ///     User account identifier
        ///     Required
        ///     Example: 664287016
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        ///     User extension identifier
        ///     Required
        ///     Example: 664307016
        /// </summary>
        public string extensionId { get; set; }
    }
}