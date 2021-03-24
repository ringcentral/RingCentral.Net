using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RingCentral.Tests
{
    // Note: this test class is for API troubleshooting only
    // Please do not reference the code here, it should not be used in production
    public class NullTest
    {
        [Fact]
        public void Conversion()
        {
            object attachment = new Attachment
            {
                filename = "test.png"
            };
            var attachments = attachment;
            attachments = new[] {attachments};
            Assert.NotNull(attachments);
            Assert.Null(attachments as IEnumerable<Attachment>); // conversion result is null
            Assert.NotNull((object[]) attachments);
            var newAttachments = ((object[]) attachments).Select(a => a as Attachment);
            Assert.NotNull(newAttachments); // conversion result is not null
        }
    }
}