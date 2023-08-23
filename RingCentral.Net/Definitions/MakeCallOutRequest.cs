namespace RingCentral
{
    public class MakeCallOutRequest
    {
        /// <summary>
        ///     Required
        /// </summary>
        public MakeCallOutCallerInfoRequestFrom from { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public MakeCallOutCallerInfoRequestTo to { get; set; }

        /// <summary>
        ///     Optional. Dialing plan country data. If not specified, then extension home country is applied by default.
        ///     Format: int64
        /// </summary>
        public long? countryId { get; set; }
    }
}