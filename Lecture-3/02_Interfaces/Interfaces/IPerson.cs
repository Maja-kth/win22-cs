namespace _02_Interfaces.Interfaces
{
    internal interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
    }
}
