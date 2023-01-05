using _00_Repetition.Interfaces;
using _00_Repetition.Models;

var employees = new List<IEmployee>()
{
    new CEO() { Id = Guid.NewGuid(), FirstName = "Hans", LastName = "Mattin-Lassei", Email = "hans@domain.com" },
    new Consultant() { Id = Guid.NewGuid(), FirstName = "Joakim", LastName = "Wahlström", Email = "joakim@domain.com", Skills = new List<string>{ "C#", "Javascript", "HTML & CSS", "SQL" }}
};
 
foreach(var employee in employees)
{
    if(employee is CEO)
    {
        var _employee = (ICEO)employee;
        Console.WriteLine(_employee.DisplayName);
        Console.WriteLine(_employee.BeneficialOwner);
    }
    else if (employee is Consultant) 
    {
        var _employee = (IConsultant)employee;
        Console.WriteLine(_employee.DisplayName);
        foreach (var skill in _employee.Skills)
            Console.WriteLine($"- {skill}");
    }
    Console.WriteLine("");
}





Console.ReadKey();
