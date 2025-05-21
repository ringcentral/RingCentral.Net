namespace RingCentral
{
    /// <summary>
    ///     Caller ID information
    /// </summary>
    public class CommFromResource
    {
        /// <summary>
        ///     Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format
        ///     Required
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Caller name
        ///     Required
        /// </summary>
        public string name { get; set; }
    }
}