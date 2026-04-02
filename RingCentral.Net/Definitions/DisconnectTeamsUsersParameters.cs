namespace RingCentral
  {
    /// <summary>
/// Query parameters for operation disconnectTeamsUsers
/// </summary>
      public class DisconnectTeamsUsersParameters
      {
          /// <summary>
        ///     List of extension IDs to filter the list of Microsoft Teams Direct Routing users
        /// </summary>
        public string[] extensionIds { get; set; }
      }
  }