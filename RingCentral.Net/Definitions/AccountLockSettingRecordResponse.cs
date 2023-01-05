namespace RingCentral
{
    public class AccountLockSettingRecordResponse
    {
        /// <summary>
        /// </summary>
        public bool? localRecording { get; set; }

        /// <summary>
        /// </summary>
        public bool? cloudRecording { get; set; }

        /// <summary>
        /// </summary>
        public bool? autoRecording { get; set; }

        /// <summary>
        /// </summary>
        public bool? cloudRecordingDownload { get; set; }

        /// <summary>
        /// </summary>
        public bool? hostDeleteCloudRecording { get; set; }

        /// <summary>
        /// </summary>
        public bool? accountUserAccessRecording { get; set; }

        /// <summary>
        /// </summary>
        public bool? autoDeleteCmr { get; set; }
    }
}