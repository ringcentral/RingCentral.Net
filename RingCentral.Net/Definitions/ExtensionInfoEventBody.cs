namespace RingCentral
{
    public class ExtensionInfoEventBody
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string extensionId;

        /// <summary>
        /// Type of extension info change
        /// Enum: Update, Delete
        /// </summary>
        public string eventType;

        /// <summary>
        /// Returned for 'Update' event type only. The possible values are: /nAccountInfo - change of account parameters/nExtensionInfo - change of contact info, service features, departments, status/nPhoneNumber - change of phone numbers/nRole - change of permissions/nProfileImage - change of profile image
        /// </summary>
        public string[] hints;

        /// <summary>
        /// Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId;
    }
}