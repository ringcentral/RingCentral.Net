namespace RingCentral
{
    public class ExtensionServiceFeatureInfo
    {
        /// <summary>
        ///     Feature status; shows feature availability for an extension
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Feature name
        ///     Enum: AccountFederation, Archiver, AutomaticCallRecordingMute, AutomaticInboundCallRecording,
        ///     AutomaticOutboundCallRecording, BlockedMessageForwarding, Calendar, CallerIdControl, CallForwarding, CallPark,
        ///     CallParkLocations, CallSupervision, CallSwitch, CallQualitySurvey, Conferencing, ConferencingNumber,
        ///     ConfigureDelegates, DeveloperPortal, DND, DynamicConference, EmergencyAddressAutoUpdate, EmergencyCalling,
        ///     EncryptionAtRest, ExternalDirectoryIntegration, Fax, FaxReceiving, FreeSoftPhoneLines, HDVoice, HipaaCompliance,
        ///     Intercom, InternationalCalling, InternationalSMS, LinkedSoftphoneLines, MMS, MobileVoipEmergencyCalling,
        ///     OnDemandCallRecording, Pager, PagerReceiving, Paging, PasswordAuth, PromoMessage, Reports, Presence, RCTeams,
        ///     RingOut, SalesForce, SharedLines, SingleExtensionUI, SiteCodes, SMS, SMSReceiving, SoftPhoneUpdate,
        ///     TelephonySessions, UserManagement, VideoConferencing, VoipCalling, VoipCallingOnMobile, Voicemail, VoicemailToText,
        ///     WebPhone
        /// </summary>
        public string featureName { get; set; }

        /// <summary>
        ///     Reason for limitation of a particular service feature. Returned
        ///     only if the enabled parameter value is `false`, see Service Feature
        ///     Limitations and Reasons. When retrieving service features for an extension,
        ///     the reasons for limitations, if any, are returned in response
        /// </summary>
        public string reason { get; set; }
    }
}