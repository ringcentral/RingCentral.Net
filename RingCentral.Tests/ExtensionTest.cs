using System;
using Newtonsoft.Json;
using Xunit;

namespace RingCentral.Tests
{
    public class ExtensionTest
    {
        [Fact]
        public async void TestGet()
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
                var extension = await rc.Restapi().Account().Extension().Get();
                Assert.NotNull(extension);
                Assert.True(extension.contact.firstName.Length > 0);
            }
        }

        [Fact]
        public void Deserialize()
        {
            var s = @"{
  ""uri"" : ""https://api.ringcentral.com/restapi/v1.0/account/1420683014/extension/1420683014"",
  ""id"" : 1420683014,
  ""extensionNumber"" : ""101"",
  ""contact"" : {
    ""firstName"" : ""lancy_ATT_Pro_5.11"",
    ""lastName"" : ""Wang"",
    ""company"" : ""dins"",
    ""email"" : ""cathy.chen+1@ringcentral.com"",
    ""businessPhone"" : ""+16502413978"",
    ""businessAddress"" : {
      ""street"" : ""afeddf"",
      ""city"" : ""dfa"",
      ""state"" : ""CA"",
      ""zip"" : ""34344"",
      ""country"" : ""United States""
    }
  },
  ""name"" : ""lancy_ATT_Pro_5.11 Wang"",
  ""type"" : ""DigitalUser"",
  ""status"" : ""Enabled"",
  ""departments"" : [ {
    ""uri"" : ""https://api.ringcentral.com/restapi/v1.0/account/1420683014/extension/1421118014"",
    ""id"" : ""1421118014"",
    ""extensionNumber"" : ""1""
  }, {
    ""uri"" : ""https://api.ringcentral.com/restapi/v1.0/account/1420683014/extension/1459034014"",
    ""id"" : ""1459034014"",
    ""extensionNumber"" : ""14""
  }, {
    ""uri"" : ""https://api.ringcentral.com/restapi/v1.0/account/1420683014/extension/1459027014"",
    ""id"" : ""1459027014"",
    ""extensionNumber"" : ""6""
  } ],
  ""serviceFeatures"" : [ {
    ""featureName"" : ""SMS"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""SMSReceiving"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""Pager"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""PagerReceiving"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""Voicemail"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""Fax"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""FaxReceiving"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""DND"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""RingOut"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""InternationalCalling"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""Presence"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""VideoConferencing"",
    ""enabled"" : false,
    ""reason"" : ""AccountLimitation""
  }, {
    ""featureName"" : ""SalesForce"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""Intercom"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""Paging"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""Conferencing"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""VoipCalling"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""FreeSoftPhoneLines"",
    ""enabled"" : false,
    ""reason"" : ""AccountTypeLimitation""
  }, {
    ""featureName"" : ""HipaaCompliance"",
    ""enabled"" : false,
    ""reason"" : ""AccountTypeLimitation""
  }, {
    ""featureName"" : ""CallPark"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""OnDemandCallRecording"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""Reports"",
    ""enabled"" : false,
    ""reason"" : ""AccountTypeLimitation""
  }, {
    ""featureName"" : ""CallForwarding"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""DeveloperPortal"",
    ""enabled"" : false,
    ""reason"" : ""AccountLimitation""
  }, {
    ""featureName"" : ""EncryptionAtRest"",
    ""enabled"" : false,
    ""reason"" : ""AccountLimitation""
  }, {
    ""featureName"" : ""BlockedMessageForwarding"",
    ""enabled"" : false,
    ""reason"" : ""AccountLimitation""
  }, {
    ""featureName"" : ""EmergencyCalling"",
    ""enabled"" : false,
    ""reason"" : ""AccountLimitation""
  }, {
    ""featureName"" : ""HDVoice"",
    ""enabled"" : false,
    ""reason"" : ""AccountTypeLimitation""
  }, {
    ""featureName"" : ""SingleExtensionUI"",
    ""enabled"" : false,
    ""reason"" : ""AccountLimitation""
  }, {
    ""featureName"" : ""CallSupervision"",
    ""enabled"" : false,
    ""reason"" : ""AccountTypeLimitation""
  }, {
    ""featureName"" : ""VoicemailToText"",
    ""enabled"" : false,
    ""reason"" : ""AccountTypeLimitation""
  }, {
    ""featureName"" : ""WebPhone"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""RCTeams"",
    ""enabled"" : false,
    ""reason"" : ""AccountTypeLimitation""
  }, {
    ""featureName"" : ""UserManagement"",
    ""enabled"" : false,
    ""reason"" : ""AccountLimitation""
  }, {
    ""featureName"" : ""Calendar"",
    ""enabled"" : true
  }, {
    ""featureName"" : ""SoftPhoneUpdate"",
    ""enabled"" : true
  } ],
  ""regionalSettings"" : {
    ""timezone"" : {
      ""uri"" : ""https://api.ringcentral.com/restapi/v1.0/dictionary/timezone/58"",
      ""id"" : ""58"",
      ""name"" : ""US/Pacific"",
      ""description"" : ""Pacific Time (US & Canada)""
    },
    ""homeCountry"" : {
      ""uri"" : ""https://api.ringcentral.com/restapi/v1.0/dictionary/country/1"",
      ""id"" : ""1"",
      ""name"" : ""United States"",
      ""isoCode"" : ""US"",
      ""callingCode"" : ""1""
    },
    ""language"" : {
      ""id"" : ""1033"",
      ""name"" : ""English (United States)"",
      ""localeCode"" : ""en-US""
    },
    ""greetingLanguage"" : {
      ""id"" : ""1033"",
      ""name"" : ""English (United States)"",
      ""localeCode"" : ""en-US""
    },
    ""formattingLocale"" : {
      ""id"" : ""1033"",
      ""name"" : ""English (United States)"",
      ""localeCode"" : ""en-US""
    },
    ""timeFormat"" : ""12h""
  },
  ""setupWizardState"" : ""Completed"",
  ""permissions"" : {
    ""admin"" : {
      ""enabled"" : true
    },
    ""internationalCalling"" : {
      ""enabled"" : true
    }
  },
  ""profileImage"" : {
    ""uri"" : ""https://api.ringcentral.com/restapi/v1.0/account/1420683014/extension/1420683014/profile-image"",
    ""etag"" : ""f1aab261b0c416a2aa690919a321209b"",
    ""contentType"" : ""image/jpeg"",
    ""lastModified"" : ""2016-01-21T07:56:35.645Z"",
    ""scales"" : [ {
      ""uri"" : ""https://api.ringcentral.com/restapi/v1.0/account/1420683014/extension/1420683014/profile-image/90x90""
    }, {
      ""uri"" : ""https://api.ringcentral.com/restapi/v1.0/account/1420683014/extension/1420683014/profile-image/195x195""
    }, {
      ""uri"" : ""https://api.ringcentral.com/restapi/v1.0/account/1420683014/extension/1420683014/profile-image/584x584""
    } ]
  }
}";
            var ext = JsonConvert.DeserializeObject<GetExtensionInfoResponse>(s);
            Assert.NotNull(ext);
            Assert.Equal("101", ext.extensionNumber);
            Assert.Equal(3, ext.departments.Length);
        }
    }
}