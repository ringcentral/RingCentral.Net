using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Security;
using PubnubApi;

namespace RingCentral.Net.PubNub
{
    public class PubNubExtension : SdkExtension
    {
        public RestClient rc;
        public readonly List<Subscription> subscriptions = new List<Subscription>();

        public PubNubExtension()
        {
            var frameworkDescription = RuntimeInformation.FrameworkDescription;
            if (!frameworkDescription.StartsWith(".NET Framework "))
            {
                throw new NotSupportedException(@"Package RingCentral.NET.Pubnub only supports .NET Framework. 
Please install package RingCentral.Net.PubnubPCL instead.");
            }
        }

        public override void Install(RestClient restClient)
        {
            this.rc = restClient;
        }

        public async void Revoke()
        {
            foreach (var subscription in subscriptions)
            {
                await subscription.Revoke();
            }

            this.subscriptions.Clear();
        }

        public async Task<Subscription> Subscribe(string[] eventFilters, Action<string> callback)
        {
            var subscription = new Subscription(this, eventFilters, callback);
            await subscription.Subscribe();
            this.subscriptions.Add(subscription);
            return subscription;
        }
    }
    public class Subscription
    {
        public PubNubExtension pne;
        public string[] eventFilters;
        public Action<string> callback;
        private Pubnub pubnub;

        private bool renewScheduled;
        private SubscriptionInfo _subscriptionInfo;

        public SubscriptionInfo subscriptionInfo
        {
            get => _subscriptionInfo;
            set
            {
                _subscriptionInfo = value;
                if (value == null || renewScheduled) return;
                Debug.Assert(_subscriptionInfo.expiresIn != null, "subscriptionInfo.expiresIn != null");
                Task.Delay((int) (_subscriptionInfo.expiresIn.Value - 120) * 1000).ContinueWith(
                    async action =>
                    {
                        // 2 minutes before expiration
                        renewScheduled = false;
                        await Refresh();
                    });
                renewScheduled = true;
            }
        }

        internal Subscription(PubNubExtension pne, string[] eventFilters, Action<string> callback)
        {
            this.pne = pne;
            this.eventFilters = eventFilters;
            this.callback = callback;
        }

        internal async Task<SubscriptionInfo> Subscribe()
        {
            var requestBody = new
            {
                eventFilters,
                deliveryMode = new {transportType = "PubNub", encryption = true}
            };
            var httpContent = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8,
                "application/json");
            subscriptionInfo = await pne.rc.Post<SubscriptionInfo>("/restapi/v1.0/subscription", httpContent);

            var pnConfiguration = new PNConfiguration
            {
                SubscribeKey = subscriptionInfo.deliveryMode.subscriberKey,
                ReconnectionPolicy = PNReconnectionPolicy.LINEAR,
                Origin = "ringcentral.pubnubapi.com"
            };
            pubnub = new Pubnub(pnConfiguration);
            pubnub.AddListener(new SubscribeCallbackExt(
                (pubnubObj, message) => { callback(Decrypt(message.Message.ToString())); },
                (pubnubObj, presence) => { },
                (pubnubObj, status) => { }
            ));
            pubnub.Subscribe<string>().Channels(new[]
            {
                subscriptionInfo.deliveryMode.address
            }).Execute();

            return subscriptionInfo;
        }

        public async Task<SubscriptionInfo> Refresh()
        {
            subscriptionInfo =
                await pne.rc.Post<SubscriptionInfo>($"/restapi/v1.0/subscription/{subscriptionInfo.id}/renew", null);
            return subscriptionInfo;
        }

        public async Task<HttpResponseMessage> Revoke()
        {
            try
            {
                var r = await pne.rc.Delete($"/restapi/v1.0/subscription/{_subscriptionInfo.id}");
                return r;
            }
            catch (RestException re)
            {
                if (re.httpResponseMessage.StatusCode == HttpStatusCode.NotFound) // already deleted
                {
                    return re.httpResponseMessage;
                }

                throw;
            }
            finally
            {
                pubnub.Destroy();
                pubnub = null;
                subscriptionInfo = null;
            }
        }

        private string Decrypt(string dataString)
        {
            var key = Convert.FromBase64String(subscriptionInfo.deliveryMode.encryptionKey);
            var keyParameter = ParameterUtilities.CreateKeyParameter("AES", key);
            var cipher = CipherUtilities.GetCipher("AES/ECB/PKCS7Padding");
            cipher.Init(false, keyParameter);

            var data = Convert.FromBase64String(dataString);
            var memoryStream = new MemoryStream(data, false);
            var cipherStream = new CipherStream(memoryStream, cipher, null);

            const int bufferSize = 1024;
            var buffer = new byte[bufferSize];
            var length = 0;
            var resultStream = new MemoryStream();
            while ((length = cipherStream.Read(buffer, 0, bufferSize)) > 0)
            {
                resultStream.Write(buffer, 0, length);
            }

            var resultBytes = resultStream.ToArray();
            return Encoding.UTF8.GetString(resultBytes, 0, resultBytes.Length);
        }
    }
}