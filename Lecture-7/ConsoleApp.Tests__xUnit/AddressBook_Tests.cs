using ConsoleApp.Models;
using ConsoleApp.Services;

namespace ConsoleApp.Tests__xUnit
{
    public class AddressBook_Tests
    {
        private AddressBook addressBook;
        Contact contact;

        public AddressBook_Tests()
        {
            // arrange
            addressBook = new AddressBook();
            contact = new Contact();
        }

        [Fact]
        public void Should_Add_Contact_To_List()
        {
            addressBook.ContactList.Add(contact);
            addressBook.ContactList.Add(contact);

            // assert
            Assert.Equal(2, addressBook.ContactList.Count);

        }


        [Fact]
        public void Should_Remove_Contact_From_List()
        {
            // arrange 
            addressBook.ContactList.Add(contact);
            addressBook.ContactList.Add(contact);

            // act
            addressBook.ContactList.Remove(contact);

            // assert
            Assert.Single(addressBook.ContactList);
        }
    }
}
