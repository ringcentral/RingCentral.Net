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
    }
}