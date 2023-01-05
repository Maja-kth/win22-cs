using _01_Generics.Interfaces;

namespace _01_Generics.Models
{
    internal class CEO : Employee, ICEO
    {
        public bool BeneficialOwner { get; set; }
    }
}
