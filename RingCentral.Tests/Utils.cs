using System.IO;
using System.Text;
using Xunit.Abstractions;

namespace RingCentral.Tests
{
    public class MyTextWriter : TextWriter
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public MyTextWriter(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        public override void WriteLine(string value)
        {
            _testOutputHelper.WriteLine(value);
        }

        public override Encoding Encoding => Encoding.UTF8;
    }
}