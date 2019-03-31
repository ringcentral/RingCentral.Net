namespace RingCentral
{
    public class GlipPersonInfo
    {
        /// <summary>
        /// Internal identifier of a user
        /// Required
        /// </summary>
        public string id;

        /// <summary>
        /// First name of a user
        /// </summary>
        public string firstName;

        /// <summary>
        /// Last name of a user
        /// </summary>
        public string lastName;

        /// <summary>
        /// Email of a user
        /// </summary>
        public string email;

        /// <summary>
        /// Photo of a user
        /// </summary>
        public string avatar;

        /// <summary>
        /// Internal identifier of a company
        /// </summary>
        public string companyId;

        /// <summary>
        /// Time of creation in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Time of the last modification in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        public string lastModifiedTime;
    }
}