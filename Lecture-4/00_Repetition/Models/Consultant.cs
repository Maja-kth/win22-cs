using _00_Repetition.Interfaces;
namespace _00_Repetition.Models;

internal class Consultant : Employee, IConsultant
{
    public List<string> Skills { get; set; } = new List<string>();
}
