/*
    SOLID   - Single Responsibility Principle, Open-Closed Principle, Liskov Substitution Priciple, Interface Segregation Principle, Dependency Inversion Principle
    DRY     - Don't Repeat Yourself
*/




using _00_Repetition.Models;
using _00_Repetition.Services;

var personService = new PersonService();

var person_1 = new Person();
person_1.FirstName = "Hans";
person_1.LastName = "Mattin-Lassei";
personService.AddPersonToList(person_1);


var person_2 = new Person();
person_2.FirstName = "Tommy";
person_2.LastName = "Mattin-Lassei";
personService.AddPersonToList(person_2);



var people = personService.GetPeopleFromList();
people.Add(person_1);
people.Remove(person_1);