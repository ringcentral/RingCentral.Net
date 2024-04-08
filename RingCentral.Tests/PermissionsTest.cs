using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class PermissionsTest
    {
        [Fact]
        public async void GetPermissions()
        {
            var rc = await SharedRestClient.GetInstance();

            var str = await rc.Get<string>("/restapi/v1.0/dictionary/permission/HUD");
            Assert.Contains("HUD", str);
        }
    }
}