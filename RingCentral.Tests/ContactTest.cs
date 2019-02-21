using System;
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
                    await addressBook.Contact(item.id).Delete();
                }

                // list
                var list = await addressBook.Contact().List();
                Assert.NotNull(list);
                Assert.Equal(1, list.paging.page);
                var total = list.paging.totalElements;

                // create
                var contact = await addressBook.Contact().Post(new PersonalContactResource
                {
                    firstName = "Tyler",
                    lastName = "Long",
                    homePhone = phoneNumber
                });
                Assert.NotNull(contact);
                Assert.Equal("Long", contact.lastName);

                // list again
                list = await addressBook.Contact().List();
                Assert.Equal(total + 1, list.paging.totalElements);

                // search
                list = await addressBook.Contact().List(new ListContactsParameters {phoneNumber = new[] {phoneNumber}});
                Assert.Equal(1, list.paging.totalElements);
                var contactId = list.records[0].id;

                // update
                contact.lastName = "Liu";
                var contact2 = await addressBook.Contact(contactId).Put(contact);
                Assert.NotNull(contact2);
                Assert.Equal("Liu", contact2.lastName);

                // get
                var contact3 = await addressBook.Contact(contactId).Get();
                Assert.NotNull(contact3);
                Assert.Equal("Tyler", contact3.firstName);
                Assert.Equal("Liu", contact3.lastName);

                // delete
                await addressBook.Contact(contactId).Delete();

                // search again
                list = await addressBook.Contact()
                    .List(new ListContactsParameters() {phoneNumber = new[] {phoneNumber}});
                Assert.Equal(0, list.paging.totalElements);
            }
        }
    }
}