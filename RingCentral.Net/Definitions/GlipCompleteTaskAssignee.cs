namespace RingCentral
{
    public class GlipCompleteTaskAssignee
    {
        /// <summary>
        /// Internal identifier of an assignee (RC extension ID or Glip user ID). 'Mandatory' if `completenessCondition` is set to `AllAssignees`, otherwise 'Optional'
        /// </summary>
        public string id;
    }
}