namespace _01_Generics.Interfaces;

internal interface IEmployee
{
    Guid Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string Email { get; set; }
    string DisplayName => $"{FirstName} {LastName}";
}
