using System;
using Newtonsoft.Json;
using Xunit;

namespace RingCentral.Tests
{
    public class ContactTest
    {
        [Fact]
        public async void ContactActions()
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
                const string phoneNumber = "+15889546648";
                var addressBook = rc.Restapi().Account().Extension().AddressBook();

                var listt = await addressBook.Contact().List(new ListContactsParameters
                    {phoneNumber = new[] {phoneNumber}});
                foreach (var item in listt.records)
                {
                    await addressBook.Contact(item.id.ToString()).Delete();
                }

                // list
                var list = await addressBook.Contact().List();
                Assert.NotNull(list);
                Assert.Equal(1, list.paging.page);
                var total = list.paging.totalElements;

                // create
                var contact = await addressBook.Contact().Post(new PersonalContactRequest
                {
                    firstName = "FirstName",
                    lastName = "LastName",
                    homePhone = phoneNumber
                });
                Assert.NotNull(contact);
                Assert.Equal("LastName", contact.lastName);

                // list again
                list = await addressBook.Contact().List();
                Assert.Equal(total + 1, list.paging.totalElements);

                // search
                list = await addressBook.Contact().List(new ListContactsParameters {phoneNumber = new[] {phoneNumber}});
                Assert.Equal(1, list.paging.totalElements);
                var contactId = list.records[0].id;

                // update
                contact.lastName = "LastName2";
                var contactRequest =
                    JsonConvert.DeserializeObject<PersonalContactRequest>(JsonConvert.SerializeObject(contact));
                var contact2 = await addressBook.Contact(contactId.ToString()).Put(contactRequest);
                Assert.NotNull(contact2);
                Assert.Equal("LastName2", contact2.lastName);

                // get
                var contact3 = await addressBook.Contact(contactId.ToString()).Get();
                Assert.NotNull(contact3);
                Assert.Equal("FirstName", contact3.firstName);
                Assert.Equal("LastName2", contact3.lastName);

                // delete
                await addressBook.Contact(contactId.ToString()).Delete();

                // search again
                list = await addressBook.Contact()
                    .List(new ListContactsParameters() {phoneNumber = new[] {phoneNumber}});
                Assert.Equal(0, list.paging.totalElements);
            }
        }
    }
}