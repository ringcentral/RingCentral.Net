namespace RingCentral
{
    public class SearchSmsConsentRecordsRequest
    {
        /// <summary>
        ///     The internal party's phone number(s) used to filter records
        ///     (if requested `coverage` is `PhoneNumber` or `Account`)
        /// </summary>
        public string[] from { get; set; }

        /// <summary>
        ///     The external party's phone number(s) used to filter records
        /// </summary>
        public string[] to { get; set; }

        /// <summary>
        ///     Consent status of a recipient's phone number:
        ///     - `OptOut` - The number is opted out of receiving SMS.
        ///     - `OptIn` - The number is opted in to receiving SMS (if it was previously opted out).
        ///     Example: OptOut
        ///     Enum: OptOut, OptIn
        /// </summary>
        public string optStatus { get; set; }

        /// <summary>
        ///     The coverage(s) used to filter records
        ///     Enum: PhoneNumber, Account, CampaignType
        /// </summary>
        public string[] coverage { get; set; }

        /// <summary>
        ///     The campaign type(s) used to filter records
        ///     (if requested `coverage` is `Campaign`)
        ///     Enum: Conversational, Informational, Promotional
        /// </summary>
        public string[] campaignType { get; set; }

        /// <summary>
        ///     The token indicating the particular page of the result set to be retrieved.
        ///     If omitted the first page will be returned.
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     The number of items per page. If provided value in the request
        ///     is greater than a maximum, the maximum value is applied
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }
    }
}