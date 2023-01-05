namespace RingCentral
{
    public class GetAccountInfoResponse
    {
        /// <summary>
        ///     Internal identifier of an account
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Canonical URI of an account
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of an account in the billing system
        /// </summary>
        public string bsid { get; set; }

        /// <summary>
        ///     Main phone number of the current account
        /// </summary>
        public string mainNumber { get; set; }

        /// <summary>
        /// </summary>
        public AccountOperatorInfo @operator { get; set; }

        /// <summary>
        ///     Additional account identifier, created by partner application
        ///     and applied on client side
        /// </summary>
        public string partnerId { get; set; }

        /// <summary>
        /// </summary>
        public ServiceInfo serviceInfo { get; set; }

        /// <summary>
        ///     Specifies account configuration wizard state (web service setup)
        ///     Default: NotStarted
        ///     Enum: NotStarted, Incomplete, Completed
        /// </summary>
        public string setupWizardState { get; set; }

        /// <summary>
        /// </summary>
        public SignupInfoResource signupInfo { get; set; }

        /// <summary>
        ///     Status of the current account
        ///     Enum: Initial, Confirmed, Unconfirmed, Disabled
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public AccountStatusInfo statusInfo { get; set; }

        /// <summary>
        /// </summary>
        public AccountRegionalSettings regionalSettings { get; set; }

        /// <summary>
        ///     Specifies whether an account is included into any federation
        ///     of accounts or not
        /// </summary>
        public bool? federated { get; set; }

        /// <summary>
        ///     If outbound call prefix is not specified, or set to null (0),
        ///     then the parameter is not returned; the supported value range is 2-9
        ///     Format: int32
        /// </summary>
        public long? outboundCallPrefix { get; set; }

        /// <summary>
        ///     Customer facing identifier. Returned for accounts with the
        ///     turned off PBX features. Equals to main company number in
        ///     [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I)
        ///     (without ''+'' sign)format
        /// </summary>
        public string cfid { get; set; }

        /// <summary>
        /// </summary>
        public AccountLimits limits { get; set; }
    }
}