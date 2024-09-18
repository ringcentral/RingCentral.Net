namespace RingCentral
{
    public class ContentModel
    {
        /// <summary>
        ///     Array of attachments to be added to the content
        ///     Required
        /// </summary>
        public SocMsgContentAttachment[] attachments { get; set; }

        /// <summary>
        ///     Identity identifier of the content author. Not mandatory on creation,
        ///     by default it uses the token's user first identity on channel
        ///     Required
        /// </summary>
        public string authorIdentityId { get; set; }

        /// <summary>
        ///     Auto submitted content:
        ///     - won't reopen tasks or interventions
        ///     - can be used to send automatic messages like asking an user to follow on twitter, sending a survey, etc,
        ///     - doesn't get included in statistics
        ///     Required
        /// </summary>
        public bool? autoSubmitted { get; set; }

        /// <summary>
        ///     Content body. On creation this field is mandatory except for WhatsApp content
        ///     using templates. The following are the channels supported and their **max length**
        ///     restrictions (in brackets):
        ///     - *Apple Messages For Business* (10000)
        ///     - *Email* (262144)
        ///     - *RingCX Digital Messaging* (1024)
        ///     - *Facebook* (8000)
        ///     - *Google My Business* (4000)
        ///     - *Instagram* (950)
        ///     - *Instagram Messaging* (1000)
        ///     - *LinkedIn* (3000)
        ///     - *Messenger* (2000)
        ///     - *Twitter* (280)
        ///     - *Viber* (7000)
        ///     - *WhatsApp* (3800)
        ///     - *Youtube* (8000)
        ///     Required
        ///     Example: Body of the content
        /// </summary>
        public string body { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public ContentBodyFormatted bodyFormatted { get; set; }

        /// <summary>
        ///     Content input format
        ///     Required
        ///     Enum: Text, Html
        /// </summary>
        public string bodyInputFormat { get; set; }

        /// <summary>
        ///     List of the category identifiers of the content
        ///     Required
        ///     Example: 541014e17aa58d8ccf000023,541014e17aa58d8ccf002023
        /// </summary>
        public string[] categoryIds { get; set; }

        /// <summary>
        ///     Direction of the content.
        ///     * Incoming contents are received from a channel.
        ///     * Outgoing contents are exported to a channel.
        ///     Example: Incoming
        ///     Enum: Incoming, Outgoing
        /// </summary>
        public string contentDirection { get; set; }

        /// <summary>
        /// </summary>
        public ContentContextData contextData { get; set; }

        /// <summary>
        ///     Creation time of the resource.
        ///     Required
        ///     Format: date-time
        ///     Example: 2023-02-04T12:43:07Z
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Source of content
        ///     Required
        ///     Enum: Synchronizer, Interface, Api, AutoSurvey, AutoResponseTrigger, AutoRequestEmail
        /// </summary>
        public string createdFrom { get; set; }

        /// <summary>
        ///     RingCentral user identifier of the creator
        ///     Required
        ///     Example: 2683222036
        /// </summary>
        public string creatorId { get; set; }

        /// <summary>
        ///     True if the content is the first in the thread.
        /// </summary>
        public bool? firstInThread { get; set; }

        /// <summary>
        ///     External categories of the content.
        ///     Returned only if the content has `foreignCategories`
        ///     Example: foreign_category_id
        /// </summary>
        public string[] foreignCategories { get; set; }

        /// <summary>
        ///     Content identifier
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Identifier of the content identity to which this content is a reply to.
        ///     If the channel does not support discussion initiation, this parameter is mandatory
        ///     Required
        /// </summary>
        public string inReplyToAuthorIdentityId { get; set; }

        /// <summary>
        ///     Content identifier to which this content is a reply to. On creation, if omitted,
        ///     a new discussion will be created. If the channel does not support discussion initiation,
        ///     this parameter is mandatory
        ///     Required
        /// </summary>
        public string inReplyToContentId { get; set; }

        /// <summary>
        ///     Intervention identifier of the content
        ///     Required
        /// </summary>
        public string interventionId { get; set; }

        /// <summary>
        ///     Language of the content
        ///     Required
        ///     Example: En
        /// </summary>
        public string language { get; set; }

        /// <summary>
        ///     If set to `true`, then the content is publicly visible on remote channel.
        ///     Private content is NOT supported on every channel
        ///     Required
        ///     Default: true
        /// </summary>
        public bool? @public { get; set; }

        /// <summary>
        ///     If set to `true`, then the content is published on remote channel
        ///     Required
        ///     Example: true
        /// </summary>
        public bool? published { get; set; }

        /// <summary>
        ///     Rating of content. Present only if the content supports rating and rating is filled
        ///     Required
        ///     Format: int32
        ///     Example: 4
        /// </summary>
        public long? rating { get; set; }

        /// <summary>
        ///     Set to `true` if content has been deleted on remote channel
        ///     Required
        /// </summary>
        public bool? remotelyDeleted { get; set; }

        /// <summary>
        ///     Channel identifier.
        ///     Required
        ///     Example: 506d9e817aa58d1259000f12
        /// </summary>
        public string channelId { get; set; }

        /// <summary>
        ///     Type of a channel
        ///     Required
        ///     Enum: AppleMessagesForBusiness, Email, EngageMessaging, Facebook, GoogleMyBusiness, Instagram, InstagramMessaging,
        ///     Linkedin, Messenger, Twitter, Viber, WhatsApp, Youtube
        /// </summary>
        public string channelType { get; set; }

        /// <summary>
        ///     External URI of a content channel
        ///     Required
        ///     Format: uri
        /// </summary>
        public string channelUri { get; set; }

        /// <summary>
        ///     Content status
        ///     Required
        ///     Enum: New, Assigned, Replied, UserReply, UserInitiated, Ignored
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Synchronization status
        ///     Required
        ///     Example: success
        /// </summary>
        public string synchronizationStatus { get; set; }

        /// <summary>
        ///     Synchronization error details
        ///     Required
        /// </summary>
        public string synchronizationError { get; set; }

        /// <summary>
        ///     Content thread identifier
        ///     Required
        /// </summary>
        public string threadId { get; set; }

        /// <summary>
        ///     Applicable to Email channels only. The subject of the email.
        ///     This field is mandatory when initiating a discussion
        ///     Required
        ///     Example: An email title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        ///     Type of the content
        ///     Required
        ///     Example: Email
        ///     Enum: Album, AuthenticateMessage, AuthenticateResponse, Carousel, CarouselMessage, Comment, ContactMessage,
        ///     Content, Email, FormMessage, FormResponse, HsmMessage, Link, ListMessage, Media, Message, OutboundMessage,
        ///     PaymentMessage, Photo, PostbackMessage, PrivateTweet, PromptMessage, Question, Review, ReviewResponse,
        ///     RichLinkMessage, SelectMessage, Status, TemplateMessage, TimePickerMessage, Tweet, Video, VideoCallRequestMessage
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
        ///     Types of structured messages that can be used to reply to this type of message
        ///     Required
        /// </summary>
        public string[] capabilitiesSupported { get; set; }
    }
}