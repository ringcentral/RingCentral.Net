namespace RingCentral
{
    /// <summary>
    ///     Specifies a background image oa a card. Acceptable formats are PNG, JPEG, and GIF
    /// </summary>
    public class BackgroundImage
    {
        /// <summary>
        ///     Must be `BackgroundImage`
        ///     Enum: BackgroundImage
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     The URL/data URL of an image to be used as a background of a card. Acceptable formats are PNG, JPEG, and GIF
        ///     Required
        ///     Format: uri-reference
        /// </summary>
        public string url { get; set; }

        /// <summary>
        ///     Describes how the image should fill the area
        ///     Enum: cover, repeatHorizontally, repeatVertically, repeat
        /// </summary>
        public string fillMode { get; set; }

        /// <summary>
        ///     Describes how the image should be aligned if it must be cropped or if using repeat fill mode
        ///     Enum: left, center, right
        /// </summary>
        public string horizontalAlignment { get; set; }

        /// <summary>
        ///     Describes how the image should be aligned if it must be cropped or if using repeat fill mode
        ///     Enum: top, center, bottom
        /// </summary>
        public string verticalAlignment { get; set; }
    }
}