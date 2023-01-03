using _02_Interfaces.Interfaces;
using _02_Interfaces.Models;

Console.ReadKey();


Customer customer = new Customer
{
    Id = 1,
    FirstName = "Joakim",
    LastName = "Wahlström"
};

Employee employee = new Employee
{
    Id = 2,
    FirstName = "Hans",
    LastName = "Mattin-Lassei"
};

Car car = new Car
{
    Brand = "Volvo",
    Model = "XC70",
    FuelType = "Diesel"
};



var people = new List<IPerson>();
people.Add(customer);
people.Add(employee);
//people.Add(car);

foreach(var person in people)
{
    if (person is Employee)
    {
        var _person = (Employee)person;
        Console.WriteLine(_person.StreetName);
    }

    else if (person is Customer)
    {
        var _person = (Customer)person;
        Console.WriteLine(_person.StreetName);
    }


}

Console.WriteLine("\n");


var employees = new List<IEmployee>
{
    new Janitor() { Id = 1, FirstName = "A", LastName = "A"},
    new Janitor(){ Id = 2, FirstName = "B", LastName = "A"},
    new Janitor(){ Id = 3, FirstName = "C", LastName = "A"},
    new ItTechnician(){ Id = 4, FirstName = "D", LastName = "A"},
    new ItTechnician(){ Id = 5, FirstName = "E", LastName = "A"},
    new ItTechnician(){ Id = 6, FirstName = "F", LastName = "A"},
    new HrAssistant(){ Id = 7, FirstName = "G", LastName = "A"},
    new HrAssistant(){ Id = 8, FirstName = "H", LastName = "A"},
    new HrAssistant(){ Id = 9, FirstName = "I", LastName = "A"},
    new HrAssistant(){ Id = 10, FirstName = "J", LastName = "A"},
    new Supervisor(){ Id = 11, FirstName = "K", LastName = "A"},
    new Engineer(){ Id = 12, FirstName = "L", LastName = "A"},
};

foreach(var emp in employees)
{
    Console.WriteLine($"{emp.Id} - {emp.FirstName} {emp.LastName}");
}


Console.ReadKey();