using ConsoleApp.Models;
using ConsoleApp.Services;

namespace ConsoleApp.Tests__nUnit
{
    public class AddressBook_Tests
    {
        private AddressBook addressBook;
        Contact contact;

        [SetUp]
        public void Setup()
        {
            // arrange
            addressBook = new AddressBook();
            contact = new Contact();
        }

        [Test]
        public void Should_Add_Contact_To_List()
        {
            addressBook.ContactList.Add(contact);
            addressBook.ContactList.Add(contact);

            // assert
            Assert.That(addressBook.ContactList.Count, Is.EqualTo(2));
   
        }


        [Test]
        public void Should_Remove_Contact_From_List()
        {
            // arrange 
            addressBook.ContactList.Add(contact);
            addressBook.ContactList.Add(contact);

            // act
            addressBook.ContactList.Remove(contact);

            // assert
            Assert.That(addressBook.ContactList.Count, Is.EqualTo(1));
        }
    }
}
