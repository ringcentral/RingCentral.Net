using System.Net;
using Newtonsoft.Json;
using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class DictionaryTest
    {
        [Fact]
        public void MockTest()
        {
            var rc = new RestClient("", "");
            var dictionary = rc.Restapi().Dictionary();
            Assert.NotNull(dictionary);
            var location = dictionary.Location();
            Assert.NotNull(location);
            var state = dictionary.State();
            Assert.NotNull(state);
        }

        [Fact]
        public async void TestGet()
        {
            var rc = await ReusableRestClient.GetInstance();
            var country = rc.Restapi().Dictionary().Country("46");
            var response = await rc.Get(country.Path());
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Contains("China", await response.Content.ReadAsStringAsync());

            var countryResponse = await rc.Get<CountryInfoDictionaryModel>(country.Path());
            var countryResponse2 = await rc.Restapi().Dictionary().Country("46").Get();
            Assert.Equal(JsonConvert.SerializeObject(countryResponse2),
                JsonConvert.SerializeObject(countryResponse));
        }

        [Fact]
        public void TestParameters()
        {
            var rc = new RestClient("", "");
            var methodInfo = rc.Restapi().GetType().GetMethod("Dictionary");
            var parameters = methodInfo.GetParameters();
            Assert.Empty(parameters);
        }
    }
}