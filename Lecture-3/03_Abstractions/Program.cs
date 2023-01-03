

using _03_Abstractions.Models;
using _03_Abstractions.Models.Animals;

Person employee_1 = new Employee()
{
    EmployeeId = 1,
    FirstName = "Hans",
    LastName = "Mattin-Lassei"
};

Person customer_1 = new Customer()
{
    Id = 1,
    FirstName = "Joakim",
    LastName = "Wahlström"
};

Person person_1 = new Person()
{
    FirstName = "Tommy",
    LastName = "Mattin-Lassei"
};



List<Person> persons = new List<Person> { employee_1, customer_1 };
foreach(var person in persons)
    Console.WriteLine(person);



Console.WriteLine("\n");

Animal dog = new Dog() { Age = 10, Gender = "Hona" };
Animal cat = new Cat() { Age = 4, Gender = "Hane" };

dog.MakeSound();
cat.MakeSound();
dog.ShowBirthYear();
cat.ShowBirthYear();


List<Animal> animals = new List<Animal>();
animals.Add(dog);
animals.Add(cat);


Console.ReadKey();




