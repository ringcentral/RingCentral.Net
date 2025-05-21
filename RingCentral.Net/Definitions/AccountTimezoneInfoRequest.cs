namespace RingCentral
{
    public class AccountTimezoneInfoRequest
    {
        /// <summary>
        ///     Internal identifier of a timezone
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Short name of a timezone
        ///     Required
        /// </summary>
        public string name { get; set; }
    }
}