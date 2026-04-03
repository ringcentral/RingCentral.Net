namespace RingCentral
{
    public class FaxResponseTo
    {
        /// <summary>
        ///     Internal identifier of a fax recipient
        /// </summary>
        public string recipientId { get; set; }

        /// <summary>
        ///     Phone number in E.164 (with '+' sign) format
        ///     Example: +18661234567
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Name of a fax recipient listed on a fax cover page
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Message status. Different message types may have different
        ///     allowed status values. For outbound faxes the aggregated message status
        ///     is returned. If, for multi-recipient outbound message, a status for
        ///     at least one recipient is `Queued`, then the `Queued` value is returned.
        ///     If a status for at least one recipient is `SendingFailed`,
        ///     then the 'SendingFailed' value is returned. In other cases,
        ///     the `Sent` status is returned
        ///     Enum: Queued, Sent, Delivered, DeliveryFailed, SendingFailed, Received
        /// </summary>
        public string messageStatus { get; set; }

        /// <summary>
        ///     Contains party location (city, state) if one can be determined
        ///     from phoneNumber. This property is filled only when phoneNumber is not
        ///     empty and server can calculate location information from it (for example,
        ///     this information is unavailable for US toll-free numbers)
        /// </summary>
        public string location { get; set; }
    }
}