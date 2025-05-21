namespace RingCentral
{
    /// <summary>
    ///     Account sign up data
    /// </summary>
    public class SignupInfoResource
    {
        /// <summary>
        /// </summary>
        public bool? tosAccepted { get; set; }

        /// <summary>
        ///     Enum: AccountCreated, BillingEntered, CreditCardApproved, AccountConfirmed, PhoneVerificationRequired,
        ///     PhoneVerificationPassed
        /// </summary>
        public string[] signupState { get; set; }

        /// <summary>
        ///     Enum: CC_Failed, Phone_Suspicious, CC_Phone_Not_Match, AVS_Not_Available, MaxMind, CC_Blacklisted,
        ///     Email_Blacklisted, Phone_Blacklisted, Cookie_Blacklisted, Device_Blacklisted, IP_Blacklisted,
        ///     Agent_Instance_Blacklisted, Charge_Limit, Other_Country, Unknown
        /// </summary>
        public string verificationReason { get; set; }

        /// <summary>
        ///     Updates 'Send Marketing Information' flag on web interface
        /// </summary>
        public bool? marketingAccepted { get; set; }

        /// <summary>
        ///     The timestamp of account creation
        ///     Format: date-time
        ///     Example: Fri Mar 10 2023 10:07:52 GMT-0800 (Pacific Standard Time)
        /// </summary>
        public string creationTime { get; set; }
    }
}