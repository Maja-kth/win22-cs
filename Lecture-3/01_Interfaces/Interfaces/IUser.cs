namespace _01_Interfaces.Interfaces
{
    internal interface IUser
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
    }
}
