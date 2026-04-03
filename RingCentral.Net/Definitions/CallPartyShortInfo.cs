namespace RingCentral
{
    public class CallPartyShortInfo
    {
        /// <summary>
        ///     Call party phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I)(with '+' sign) format
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Call party name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Internal identifier of a call party extensionId
        /// </summary>
        public string extensionId { get; set; }
    }
}