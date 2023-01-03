using _00_Repetition.Models;
using System;

namespace _00_Repetition.Services
{
    internal class PersonService
    {
        private List<Person> people { get; set; } = new List<Person>();


        public void AddPersonToList(Person person)
        {
            var _person = GetPersonFromList(person);
            if (_person == null)
                people.Add(person);
        }

        public void RemovePersonFromList(Person person)
        {
            var _person = GetPersonFromList(person);
            if (_person != null)
                people.Remove(person);
        }

        public Person GetPersonFromList(Person person)
        {
            var _person = people.FirstOrDefault(x => x.FirstName == person.FirstName && x.LastName == person.LastName);
            return _person!;
        }

        public IEnumerable<Person> GetPeopleFromList() 
        {
            return people;
        }
    }
}
