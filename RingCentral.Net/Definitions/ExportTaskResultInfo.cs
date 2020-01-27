namespace RingCentral
{
    public class ExportTaskResultInfo
    {
        /// <summary>
        /// Internal identifier of a dataset
        /// </summary>
        public string id;

        /// <summary>
        /// Link for downloading a dataset
        /// </summary>
        public string uri;

        /// <summary>
        /// Size of ta dataset in bytes
        /// </summary>
        public long? size;
    }
}