namespace RingCentral
{
    public class UpdateEveryoneTeamRequest
    {
        /// <summary>
        ///     Everyone chat name. Maximum number of characters supported is 250
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Everyone chat description. Maximum number of characters supported is 1000
        /// </summary>
        public string description { get; set; }
    }
}