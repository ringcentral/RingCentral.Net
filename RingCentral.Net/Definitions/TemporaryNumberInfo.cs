namespace RingCentral
{
    // Temporary phone number, if any. Returned for phone numbers in `Pending` porting status only
    public class TemporaryNumberInfo
    {
        /// <summary>
        ///     Temporary phone number identifier
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Temporary phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) (with '+' sign) format
        /// </summary>
        public string phoneNumber { get; set; }
    }
}