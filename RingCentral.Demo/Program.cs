using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RingCentral.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = MainAsync(args);
            t.Wait();
        }

        private static Task<GetMessageInfoResponse> SendSms(RestClient rc)
        {
            return rc.Restapi().Account().Extension().Sms().Post(new CreateSMSMessage
            {
                from = new MessageStoreCallerInfoRequest
                {
                    phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME")
                },
                to = new[]
                {
                    new MessageStoreCallerInfoRequest
                    {
                        phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_RECEIVER")
                    }
                },
                text = "Hello world"
            });
        }

        static async Task MainAsync(string[] args)
        {
            using (var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
                );

                var eventFilters = new[]
                {
                    "/restapi/v1.0/account/~/extension/~/presence?detailedTelephonyState=true",
                    "/restapi/v1.0/account/~/extension/~/message-store"
                };
                var messages = new List<string>();
                var messageStoreMessageCount = 0;
                var subscription = new Subscription(rc, eventFilters, message =>
                {
                    messages.Add(message);
                    dynamic jObject = JObject.Parse(message);
                    var eventString = (string) jObject.@event;
                    if (new Regex("/account/\\d+/extension/\\d+/message-store").Match(eventString).Success)
                    {
                        messageStoreMessageCount += 1;
                        var messageEvent = JsonConvert.DeserializeObject<MessageEvent>(message);
                        Debug.Assert(messageEvent.uuid != null);
                        Debug.Assert(messageEvent.body != null);
                    }
                });
                var subscriptionInfo = await subscription.Subscribe();
                Debug.Assert(subscriptionInfo != null);
                Debug.Assert(subscription.subscriptionInfo != null);
                Debug.Assert(eventFilters.Length == subscriptionInfo.eventFilters.Length);
                await SendSms(rc);
                await Task.Delay(20000);
                Debug.Assert(messages.Count >= 1);
                Debug.Assert(messageStoreMessageCount >= 1);
                Debug.Assert(messages.Any(message => message.Contains("message-store")));
                subscriptionInfo = await subscription.Refresh();
                Debug.Assert(subscriptionInfo != null);
                Debug.Assert(subscription.subscriptionInfo != null);
                Debug.Assert(eventFilters.Length == subscriptionInfo.eventFilters.Length);
                await subscription.Revoke();
                Debug.Assert(subscription.subscriptionInfo == null);
            }
        }
    }
}