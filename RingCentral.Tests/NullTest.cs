using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RingCentral.Tests
{
    public class NullTest
    {
        [Fact]
        public void Conversion()
        {
            object attachment = new Attachment
            {
                fileName = "test.png"
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