namespace RingCentral
{
    public class ContentModel
    {
        /// <summary>
        ///     An array containing the attachments that are attached to the content.
        ///     Required
        /// </summary>
        public ContentAttachment[] attachments { get; set; }

        /// <summary>
        ///     Identity identifier of the author of content.
        ///     Not mandatory on creation, by default it uses the token's user first identity on channel.
        ///     Required
        ///     Example: 541014e17aa58d8ccf000023
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
        ///     The content's body.
        ///     On creation this field is mandatory except for WhatsApp content using templates.
        ///     The following are the max length restrictions for the different channels supported.
        ///     Channel and max length
        ///     * Apple Messages For Business (max length 10000)
        ///     * Email (max length 262144)
        ///     * RingCX Digital Messaging (max length 1024)
        ///     * Facebook (max length 8000)
        ///     * GoogleBusinessMessages (max length 3000)
        ///     * Google My Business (max length 4000)
        ///     * Instagram (max length 950)
        ///     * Instagram Messaging (max length 1000)
        ///     * LinkedIn (max length 3000)
        ///     * Messenger (max length 2000)
        ///     * Twitter (max length 280)
        ///     * Viber (max length 7000)
        ///     * WhatsApp (max length 3800)
        ///     * Youtube (max length 8000)
        ///     Required
        ///     Example: Body of the content
        /// </summary>
        public string body { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public ContentBodyFormatted bodyFormatted { get; set; }

        /// <summary>
        ///     Values can be Text or Html.
        ///     Required
        ///     Enum: Text, Html
        /// </summary>
        public string bodyInputFormat { get; set; }

        /// <summary>
        ///     List of the category identifiers of the content.
        ///     Required
        ///     Example: 541014e17aa58d8ccf000023,541014e17aa58d8ccf002023
        /// </summary>
        public string[] categoryIds { get; set; }

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
        ///     Created from of the content.
        ///     Required
        ///     Enum: Synchronizer, Interface, Api, AutoSurvey, AutoResponseTrigger, AutoRequestEmail
        /// </summary>
        public string createdFrom { get; set; }

        /// <summary>
        ///     RC user id of the creator
        ///     Required
        ///     Example: 2683222036
        /// </summary>
        public string creatorId { get; set; }

        /// <summary>
        ///     External categories of the content.
        ///     Present only if the content has foreignCategories.
        ///     Example: foreign_category_id
        /// </summary>
        public string[] foreignCategories { get; set; }

        /// <summary>
        ///     Identifier of the content.
        ///     Required
        ///     Example: 541014e17aa58d8ccf000023
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     The identity identifier of the content to which this content is a reply to.
        ///     Required
        ///     Example: 541014e17asdd8ccf000023
        /// </summary>
        public string inReplyToAuthorIdentityId { get; set; }

        /// <summary>
        ///     The content identifier to which this content is a reply to.
        ///     On creation, if omitted, a new discussion will be created. If the channel does not support to initiate discussion
        ///     this parameter is mandatory.
        ///     Required
        ///     Example: 123414e17asdd8ccf000023
        /// </summary>
        public string inReplyToContentId { get; set; }

        /// <summary>
        ///     The intervention identifier of the content.
        ///     Required
        ///     Example: 123415437asdd8ccf000023
        /// </summary>
        public string interventionId { get; set; }

        /// <summary>
        ///     Language of the content.
        ///     Required
        ///     Example: En
        /// </summary>
        public string language { get; set; }

        /// <summary>
        ///     True if the content is publicly visible on the remote channel (default).
        ///     Private content is NOT supported on every channel.
        ///     Required
        ///     Default: true
        /// </summary>
        public bool? @public { get; set; }

        /// <summary>
        ///     True if the content is published on the remote channel.
        ///     Required
        ///     Example: true
        /// </summary>
        public bool? published { get; set; }

        /// <summary>
        ///     Rating of the content.
        ///     Present only if the content supports rating and rating is filled.
        ///     Required
        ///     Format: int32
        ///     Example: 4
        /// </summary>
        public long? rating { get; set; }

        /// <summary>
        ///     True if the content has been deleted on the remote channel.
        ///     Required
        /// </summary>
        public bool? remotelyDeleted { get; set; }

        /// <summary>
        ///     Identifier of the channel.
        ///     On creation if `inReplyToContentId` is specified, the channel will be determined from it. Otherwise, this parameter
        ///     is mandatory.
        ///     Required
        ///     Example: fff415437asdd8ccf000023
        /// </summary>
        public string sourceId { get; set; }

        /// <summary>
        ///     Type of the channel.
        ///     Required
        ///     Enum: AppleMessagesForBusiness, Email, EngageMessaging, Facebook, GoogleBusinessMessages, GoogleMyBusiness,
        ///     Instagram, InstagramMessaging, Linkedin, Messenger, Twitter, Viber, WhatsApp, Youtube
        /// </summary>
        public string sourceType { get; set; }

        /// <summary>
        ///     External Uri of the content channel.
        ///     Required
        ///     Format: uri
        /// </summary>
        public string sourceUri { get; set; }

        /// <summary>
        ///     Content status.
        ///     Required
        ///     Enum: New, Assigned, Replied, UserReply, UserInitiated, Ignored
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Synchronization status.
        ///     Required
        ///     Example: success
        /// </summary>
        public string synchronizationStatus { get; set; }

        /// <summary>
        ///     Synchronization error details.
        ///     Required
        /// </summary>
        public string synchronizationError { get; set; }

        /// <summary>
        ///     Content thread identifier of the content.
        ///     Required
        /// </summary>
        public string threadId { get; set; }

        /// <summary>
        ///     Applicable to Email channels only.
        ///     The subject of the email.
        ///     This field is mandatory when initiating a discussion.
        ///     Required
        ///     Example: An email title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        ///     Type of the content.
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
        ///     Types of structured messages that can be used to reply to this type of message.
        ///     Required
        /// </summary>
        public string[] capabilitiesSupported { get; set; }
    }
}