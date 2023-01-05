using _01_Generics.Interfaces;

namespace _01_Generics.Models;

internal abstract class Employee : IEmployee
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
}
