using System.Linq;
using Xunit;

// Note: this test file is for API troubleshooting only
// Please do not reference the code here, it should not be used in production
namespace RingCentral.Tests
{
    internal class A
    {
        public string b = "bb";
        public string c { get; set; } = "cc";
    }

    public class PropertyAndFieldTest
    {
        [Fact]
        public void StaticClass()
        {
            var a = new A();
            var fields = a.GetType().GetFields().Select(f => f.Name);
            Assert.Equal(new[] {"b"}, fields);
            var properties = a.GetType().GetProperties().Select(f => f.Name);
            Assert.Equal(new[] {"c"}, properties);
        }

        [Fact]
        public void DynamicClass()
        {
            var a = new
            {
                b = "b",
                c = "c"
            };
            var fields = a.GetType().GetFields().Select(f => f.Name);
            Assert.Empty(fields);
            var properties = a.GetType().GetProperties().Select(f => f.Name);
            Assert.Equal(new[] {"b", "c"}, properties);
        }

        [Fact]
        private void GetPairs()
        {
            var a = new
            {
                b = "b",
                c = "c"
            };
            var pairs = Utils.GetPairs(a);

            Assert.Equal(new[]
            {
                (name: "b", value: "b" as object),
                (name: "c", value: "c" as object)
            }, pairs.ToArray());

            var a2 = new A();
            var pairs2 = Utils.GetPairs(a2);
            Assert.Equal(new[]
            {
                (name: "b", value: "bb" as object),
                (name: "c", value: "cc" as object)
            }, pairs2.ToArray());
        }
    }
}