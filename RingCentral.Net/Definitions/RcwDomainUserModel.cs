namespace RingCentral
{
    public class RcwDomainUserModel
    {
        /// <summary>
        ///     User ID
        ///     Required
        /// </summary>
        public string userId { get; set; }

        /// <summary>
        ///     Account ID
        ///     Required
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        ///     Identity domain
        ///     Required
        ///     Default: pbx
        ///     Enum: pbx, ilm
        /// </summary>
        public string domain { get; set; }
    }
}