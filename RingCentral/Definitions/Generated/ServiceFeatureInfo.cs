namespace RingCentral
{
    public class ServiceFeatureInfo
    {
        // Feature name
        // Enum: AccountFederation, Archiver, AutomaticCallRecordingMute, AutomaticInboundCallRecording, AutomaticOutboundCallRecording, BlockedMessageForwarding, Calendar, CallerIdControl, CallForwarding, CallPark, CallParkLocations, CallSupervision, CallSwitch, CallQualitySurvey, Conferencing, ConfigureDelegates, DeveloperPortal, DND, DynamicConference, EmergencyAddressAutoUpdate, EmergencyCalling, EncryptionAtRest, ExternalDirectoryIntegration, Fax, FaxReceiving, FreeSoftPhoneLines, HDVoice, HipaaCompliance, Intercom, InternationalCalling, InternationalSMS, LinkedSoftphoneLines, MMS, OnDemandCallRecording, Pager, PagerReceiving, Paging, PasswordAuth, PromoMessage, Reports, Presence, RCTeams, RingOut, SalesForce, SingleExtensionUI, SiteCodes, SMS, SMSReceiving, SoftPhoneUpdate, UserManagement, VideoConferencing, VoipCalling, VoipCallingOnMobile, Voicemail, VoicemailToText, WebPhone
        public string featureName;

        // Feature status, shows feature availability for the extension
        public bool? enabled;
    }
}