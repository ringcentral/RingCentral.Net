namespace RingCentral
{
    public class Delegate
    {
        /// <summary>
        ///     Delegate id (equal as extension id of delegate)
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Delegate name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Delegate account id
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        ///     Delegate extension id
        ///     Required
        /// </summary>
        public string extensionId { get; set; }
    }
}