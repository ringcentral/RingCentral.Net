using System;
using Newtonsoft.Json.Linq;
using RingCentral.Net.WebSocket;
using Xunit;

namespace RingCentral.Tests
{
    public class CallControlTest
    {
        [Fact]
        public async void ForwardCall()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );
                var webSocketExtension = new WebSocketExtension();
                await rc.InstallExtension(webSocketExtension);
                var eventFilters = new[]
                {
                    "/restapi/v1.0/account/~/extension/~/presence?detailedTelephonyState=true"
                };
                var subscription = await webSocketExtension.Subscribe(eventFilters, async message =>
                {
                    dynamic jObject = JObject.Parse(message);
                    var activeCall = jObject.body.activeCalls[0];

                    if ((string) activeCall.telephonyStatus == "Ringing")
                    {
                        var telephonySessionId = (string) activeCall.telephonySessionId;
                        var partyId = (string) activeCall.partyId;
                        if (telephonySessionId != null && partyId != null)
                        {
                            var callParty = await rc.Restapi().Account().Telephony().Sessions(telephonySessionId)
                                .Parties(partyId)
                                .Forward().Post(new ForwardTarget
                                {
                                    phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_RECEIVER")
                                });
                            Assert.NotNull(callParty);
                        }
                    }
                });
                // await Task.Delay(120000);
            }
        }
    }
}