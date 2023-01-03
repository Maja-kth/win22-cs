using _01_Interfaces.Interfaces;

namespace _01_Interfaces.Models
{
    internal class User : IUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
