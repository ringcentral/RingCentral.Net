namespace RingCentral
{
    /// <summary>
    ///     Various settings which define behavior of this Webinar's Sessions
    /// </summary>
    public class WcsWebinarSettingsModel
    {
        /// <summary>
        ///     Indicates if recording is enabled (if false all other recording settings cannot be enabled)
        ///     Default: true
        /// </summary>
        public bool? recordingEnabled { get; set; }

        /// <summary>
        ///     Indicates if recording should start automatically when a Webinar goes live
        /// </summary>
        public bool? autoRecord { get; set; }

        /// <summary>
        ///     Indicates if recording can be shared (this setting is read-only at webinar level)
        ///     Default: true
        /// </summary>
        public bool? recordingSharingEnabled { get; set; }

        /// <summary>
        ///     Indicates if recording can be downloaded (this setting is read-only at webinar level)
        ///     Default: true
        /// </summary>
        public bool? recordingDownloadEnabled { get; set; }

        /// <summary>
        ///     DEPRECATED AND REPLACED BY 'pastSessionDeletionEnabled' setting.
        ///     Indicates if recording can be deleted (this setting is read-only at webinar level)
        /// </summary>
        public bool? recordingDeletionEnabled { get; set; }

        /// <summary>
        ///     Indicates if deletion of past session along with its artifacts is enabled for Host.
        ///     This setting is read-only at webinar level
        /// </summary>
        public bool? pastSessionDeletionEnabled { get; set; }

        /// <summary>
        ///     Indicates if Panelists should be places to waiting room after joining
        /// </summary>
        public bool? panelistWaitingRoom { get; set; }

        /// <summary>
        ///     Indicates if Panelists' video should be 'on' by default
        ///     Default: true
        /// </summary>
        public bool? panelistVideoEnabled { get; set; }

        /// <summary>
        ///     Indicates if Panelists' screen sharing should be 'on' by default
        ///     Default: true
        /// </summary>
        public bool? panelistScreenSharingEnabled { get; set; }

        /// <summary>
        ///     Indicates if Panelists can mute/unmute themselves by default
        ///     Default: true
        /// </summary>
        public bool? panelistMuteControlEnabled { get; set; }

        /// <summary>
        ///     Indicates if Panelists have to be authenticated users
        ///     Default: AuthenticatedCoworker
        ///     Enum: Guest, AuthenticatedUser, AuthenticatedCoworker
        /// </summary>
        public string panelistAuthentication { get; set; }

        /// <summary>
        ///     Indicates if attendees have to be authenticated users
        ///     Default: AuthenticatedCoworker
        ///     Enum: Guest, AuthenticatedUser, AuthenticatedCoworker
        /// </summary>
        public string attendeeAuthentication { get; set; }

        /// <summary>
        ///     Indicates who can access webinar artifacts. Applies to recordings at present.
        ///     Applicable to other artifacts such as Q&A, Polls in the future.
        ///     Default: AuthenticatedUser
        ///     Enum: Guest, AuthenticatedUser, AuthenticatedCoworker
        /// </summary>
        public string artifactsAccessAuthentication { get; set; }

        /// <summary>
        ///     Indicates if dial-in PSTN audio option is enabled for Panelists
        /// </summary>
        public bool? pstnEnabled { get; set; }

        /// <summary>
        ///     Webinar password. If company-level "passwordEnabled" is true and "password" is null / omitted,
        ///     the backend generates the password
        /// </summary>
        public string password { get; set; }

        /// <summary>
        ///     Indicates if Q&A is enabled for the webinar (if false all other Q&A settings cannot be enabled)
        ///     Default: true
        /// </summary>
        public bool? qnaEnabled { get; set; }

        /// <summary>
        ///     Indicates if anonymous Q&A is enabled for the webinar
        ///     Default: true
        /// </summary>
        public bool? qnaAnonymousEnabled { get; set; }

        /// <summary>
        ///     Indicates if polls are enabled for the webinar (if false all other polls settings cannot be enabled)
        ///     Default: true
        /// </summary>
        public bool? pollsEnabled { get; set; }

        /// <summary>
        ///     Indicates if anonymous poll answers are enabled for the webinar
        ///     Default: true
        /// </summary>
        public bool? pollsAnonymousEnabled { get; set; }

        /// <summary>
        ///     Indicates if a registration is enabled for the webinar (if false all other registration settings are ignored)
        /// </summary>
        public bool? registrationEnabled { get; set; }

        /// <summary>
        ///     URI to redirect users after the webinar
        ///     Format: uri
        ///     Example: https://www.acme.com/thankyou
        /// </summary>
        public string postWebinarRedirectUri { get; set; }

        /// <summary>
        ///     Indicates if livestreaming to external streaming provider is enabled
        ///     Default: true
        /// </summary>
        public bool? externalLivestreamEnabled { get; set; }
    }
}