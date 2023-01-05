/*
    GENERICS
    -----------------------------------------------------------------------------------
    T = Type (Data Type) det är som en placeholder
    TEntity = Entity Type (används för Entity Framework när vi håller på med databaser)

    public abstract class GenericService<T> where T : class {}
    public class EmployeeService : GenericService<IEmployee> {}

 */

using _01_Generics.Models;
using _01_Generics.Services;

var employeeService = new EmployeeService();
employeeService.Add(new CEO() { Id = Guid.Parse("19b4f92d-02fe-4660-8d00-3626f45b52d3"), FirstName = "Hans", LastName = "Mattin-Lassei", Email = "hans@domain.com" });
employeeService.Add(new CEO() { Id = Guid.Parse("87b4f92d-02fe-5460-8d00-3626f45b52d5"), FirstName = "Tommy", LastName = "Mattin-Lassei", Email = "tommy@domain.com" });


foreach (var employee in employeeService.GetAll())
    Console.WriteLine(employee.DisplayName);

var ceo = employeeService.Get(x => x.Id == Guid.Parse("19b4f92d-02fe-4660-8d00-3626f45b52d3"));
Console.WriteLine(ceo.DisplayName);

employeeService.Remove(x => x.Id == Guid.Parse("19b4f92d-02fe-4660-8d00-3626f45b52d3"));
foreach (var employee in employeeService.GetAll())
    Console.WriteLine(employee.DisplayName);


Console.ReadKey();