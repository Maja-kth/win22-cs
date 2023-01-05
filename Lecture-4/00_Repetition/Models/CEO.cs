using _00_Repetition.Interfaces;
namespace _00_Repetition.Models;

internal class CEO : Employee, ICEO
{
    public bool BeneficialOwner { get; set; } = true;
}
