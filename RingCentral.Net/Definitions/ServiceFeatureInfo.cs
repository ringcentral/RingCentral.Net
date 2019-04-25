namespace RingCentral
{
    public class ServiceFeatureInfo
    {
        /// <summary>
        /// Feature name
        /// Enum: AccountFederation, Archiver, AutomaticCallRecordingMute, AutomaticInboundCallRecording, AutomaticOutboundCallRecording, BlockedMessageForwarding, Calendar, CallerIdControl, CallForwarding, CallPark, CallParkLocations, CallSupervision, CallSwitch, CallQualitySurvey, Conferencing, ConfigureDelegates, DeveloperPortal, DND, DynamicConference, EmergencyAddressAutoUpdate, EmergencyCalling, EncryptionAtRest, ExternalDirectoryIntegration, Fax, FaxReceiving, FreeSoftPhoneLines, HDVoice, HipaaCompliance, Intercom, InternationalCalling, InternationalSMS, LinkedSoftphoneLines, MMS, OnDemandCallRecording, Pager, PagerReceiving, Paging, PasswordAuth, PromoMessage, Reports, Presence, RCTeams, RingOut, SalesForce, SharedLines, SingleExtensionUI, SiteCodes, SMS, SMSReceiving, SoftPhoneUpdate, TelephonySessions, UserManagement, VideoConferencing, VoipCalling, VoipCallingOnMobile, Voicemail, VoicemailToText, WebPhone
        /// </summary>
        public string featureName;

        /// <summary>
        /// Feature status, shows feature availability for the extension
        /// </summary>
        public bool? enabled;
    }
}