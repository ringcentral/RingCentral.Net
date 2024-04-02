namespace RingCentral
{
    public class IdentityModel
    {
        /// <summary>
        ///     Identity identifier.
        ///     Required
        ///     Example: 506d9e817aa58d1259000f12
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Identity's avatar Uri.
        ///     Format: uri
        ///     Example:
        ///     https://example.com/assets/avatar/default-79fd530c58c2a6b83a11fcc0e842ed7023ceb69292cfeb857bc2af2c624b90fd.png
        /// </summary>
        public string avatarUri { get; set; }

        /// <summary>
        ///     Company.
        ///     Example: Test Company
        /// </summary>
        public string company { get; set; }

        /// <summary>
        ///     Creation time of the resource.
        ///     Required
        ///     Format: date-time
        ///     Example: 2023-02-04T12:43:07Z
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Display name of the identity.
        ///     Example: John Doe
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        ///     Email address.
        ///     Format: email
        ///     Example: user@example.com
        /// </summary>
        public string emailAddress { get; set; }

        /// <summary>
        /// </summary>
        public IdentityExtraValues extraValues { get; set; }

        /// <summary>
        ///     FirstName.
        ///     Example: John
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        ///     Gender.
        ///     Example: Woman
        ///     Enum: Man, Woman
        /// </summary>
        public string gender { get; set; }

        /// <summary>
        ///     Phone number.
        ///     Example: +33634231224
        /// </summary>
        public string homePhone { get; set; }

        /// <summary>
        ///     The identity group id references the identity group that contains
        ///     all information (phone, notes, etc.). Many identities may belong to
        ///     this group. If the identity group id is null, it means that identity
        ///     does not have a group and any extra information.
        ///     Example: 54085e5b7aa58d8b5d00006c
        /// </summary>
        public string identityGroupId { get; set; }

        /// <summary>
        ///     LastName.
        ///     Example: Doe
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        ///     Phone number.
        ///     Example: +33634231224
        /// </summary>
        public string mobilePhone { get; set; }

        /// <summary>
        ///     Screen name of the identity.
        ///     Example: John D.
        /// </summary>
        public string screenName { get; set; }

        /// <summary>
        ///     Type of the identity.
        ///     Required
        ///     Enum: AppleMessagesForBusiness, Email, EngageMessaging, Facebook, GoogleBusinessMessages, GoogleMyBusiness,
        ///     Instagram, Linkedin, Twitter, Viber, WhatsApp, Youtube
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     The time when the last modification was completed.
        ///     Required
        ///     Format: date-time
        ///     Example: 2023-02-04T12:43:07Z
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     List of the associated user identifiers who can use the identity.
        /// </summary>
        public string[] userIds { get; set; }

        /// <summary>
        ///     UUID of the identity.
        ///     Example: 9680ab94-3b78-495c-bb2c-a969954d8260
        /// </summary>
        public string uuid { get; set; }

        /// <summary>
        ///     Device info of the identity.
        ///     Applicable to RingCX Digital Messaging channels only.
        ///     Example: iPhone (iPhone); iOS 15.0.2
        /// </summary>
        public string mobileDeviceInfo { get; set; }

        /// <summary>
        ///     Facebook biography of the identity.
        ///     Applicable to Facebook and Messenger channels only.
        ///     Example: Painter living in Paris
        /// </summary>
        public string fbBio { get; set; }

        /// <summary>
        ///     Facebook category of the identity.
        ///     Applicable to Facebook and Messenger channels only.
        ///     Example: Computers/Internet
        /// </summary>
        public string fbCategory { get; set; }

        /// <summary>
        ///     Facebook locale of the identity.
        ///     Applicable to Facebook and Messenger channels only.
        ///     Example: fr_FR
        /// </summary>
        public string fbLocale { get; set; }

        /// <summary>
        ///     Instagram followers count of the identity.
        ///     Applicable to Instagram and InstagramMessaging channels only.
        ///     Format: int32
        ///     Example: 10
        /// </summary>
        public long? igFollowersCount { get; set; }

        /// <summary>
        ///     Twitter description of the identity.
        ///     Applicable to Twitter channels only.
        ///     Example: Software Engineer
        /// </summary>
        public string twDescription { get; set; }

        /// <summary>
        ///     Twitter followers count of the identity.
        ///     Applicable to Twitter channels only.
        ///     Format: int32
        ///     Example: 10
        /// </summary>
        public long? twFollowersCount { get; set; }

        /// <summary>
        ///     Count of Twitter accounts followed by the identity.
        ///     Applicable to Twitter channels only.
        ///     Format: int32
        ///     Example: 500
        /// </summary>
        public long? twFollowingCount { get; set; }

        /// <summary>
        ///     Count of tweets of the identity.
        ///     Applicable to Twitter channels only.
        ///     Format: int32
        ///     Example: 42
        /// </summary>
        public long? twStatusesCount { get; set; }

        /// <summary>
        ///     Twitter location of the identity.
        ///     Applicable to Twitter channels only.
        ///     Example: Paris
        /// </summary>
        public string twLocation { get; set; }

        /// <summary>
        ///     Viber API version of the identity.
        ///     Applicable to Viber channels only.
        ///     Example: 10
        /// </summary>
        public string apiVersion { get; set; }

        /// <summary>
        ///     Viber country of the identity.
        ///     Applicable to Viber channels only.
        ///     Example: FR
        /// </summary>
        public string country { get; set; }

        /// <summary>
        ///     Viber device type of the identity.
        ///     Applicable to Viber channels only.
        ///     Example: SM-G970U1
        /// </summary>
        public string deviceType { get; set; }

        /// <summary>
        ///     Viber language of the identity.
        ///     Applicable to Viber channels only.
        ///     Example: fr-FR
        /// </summary>
        public string language { get; set; }

        /// <summary>
        ///     Viber mobile country code of the identity.
        ///     Applicable to Viber channels only.
        ///     Example: 1
        /// </summary>
        public string mcc { get; set; }

        /// <summary>
        ///     Viber mobile network code of the identity.
        ///     Applicable to Viber channels only.
        ///     Example: 220
        /// </summary>
        public string mnc { get; set; }

        /// <summary>
        ///     Viber primary device OS of the identity.
        ///     Applicable to Viber channels only.
        ///     Example: Android 11
        /// </summary>
        public string primaryDeviceOs { get; set; }

        /// <summary>
        ///     Viber application version of the identity.
        ///     Applicable to Viber channels only.
        ///     Example: 19.5.0
        /// </summary>
        public string viberVersion { get; set; }
    }
}