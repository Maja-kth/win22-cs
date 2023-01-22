using FluentAssertions;
using System.Collections.ObjectModel;
using WpfApp.MVVM.Models;
using WpfApp.MVVM.ViewModels;

namespace WpfApp.Tests
{
    public class ContactsViewModel_Tests
    {
        private ContactsViewModel viewModel;
        public ContactsViewModel_Tests()
        {
            viewModel= new ContactsViewModel();
        }
        

        [Fact]
        public void Should_Add_Contact_To_ContactList()
        {
            // act
            Contact contact = new Contact { FirstName = "Hans", LastName = "Mattin-Lassei" };
            viewModel.ContactList.Add(contact);

            // assert
            viewModel.ContactList.Should().BeOfType<ObservableCollection<Contact>>();
            viewModel.ContactList.Should().Contain(contact);
        }
    }
}