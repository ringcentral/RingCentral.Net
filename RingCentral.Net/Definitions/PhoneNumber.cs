namespace RingCentral
{
    public class PhoneNumber
    {
        /// <summary>
        ///     Required
        ///     Enum: work, mobile, other
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public string value { get; set; }
    }
}