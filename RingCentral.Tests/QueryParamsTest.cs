using System.Net.Http;
using RingCentral.Net.Events;
using Xunit;

namespace RingCentral.Tests;

[Collection("Sequential")]
public class QueryParamsTest
{
    [Fact]
    public async void ArrayParams()
    {
        var rc = await ReusableRestClient.GetInstance();
        var eventsExtension = new EventsExtension();
        await rc.InstallExtension(eventsExtension);

        var count = 0;
        const string phoneNumber = "+15889546648";
        const string phoneNumber2 = "+17700083226";
        var addressBook = rc.Restapi().Account().Extension().AddressBook();

        void EventHandler1(object sender, HttpRequestMessage httpRequestMessage)
        {
            Assert.Equal($"?phoneNumber={phoneNumber.Replace("+", "%2B")}", httpRequestMessage.RequestUri.Query);
            count += 1;
        }

        eventsExtension.BeforeRequest += EventHandler1;
        await addressBook.Contact().List(new ListContactsParameters { phoneNumber = new[] { phoneNumber } });
        eventsExtension.BeforeRequest -= EventHandler1;
        Assert.Equal(1, count);

        void EventHandler2(object sender, HttpRequestMessage httpRequestMessage)
        {
            Assert.Equal($"?phoneNumber={phoneNumber}&phoneNumber={phoneNumber2}".Replace("+", "%2B"),
                httpRequestMessage.RequestUri.Query);
            count += 1;
        }

        eventsExtension.BeforeRequest += EventHandler2;
        await addressBook.Contact().List(new ListContactsParameters
            { phoneNumber = new[] { phoneNumber, phoneNumber2 } });
        eventsExtension.BeforeRequest -= EventHandler2;
        Assert.Equal(2, count);

        eventsExtension.enabled = false;
    }
}