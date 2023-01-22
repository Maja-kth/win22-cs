using ConsoleApp.Models;
using ConsoleApp.Services;

namespace ConsoleApp.Tests__MSTest
{
    [TestClass]
    public class AddressBook_Tests
    {

        [TestMethod]
        public void Should_Add_Contact_To_List()
        {
            // arrange
            AddressBook addressBook = new AddressBook();
            Contact contact = new Contact();
            
            // act
            addressBook.ContactList.Add(contact);

            // assert
            Assert.AreEqual(1, addressBook.ContactList.Count);
        }

        [TestMethod]
        public void Should_Remove_Contact_From_List()
        {
            // arrange
            AddressBook addressBook = new AddressBook();
            Contact contact = new Contact();
            addressBook.ContactList.Add(contact);

            // act
            addressBook.ContactList.Remove(contact);

            // assert
            Assert.AreEqual(0, addressBook.ContactList.Count);
        }
    }
}
