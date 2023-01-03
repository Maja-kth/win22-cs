using _03_Abstractions.Interfaces;

namespace _03_Abstractions.Models.Animals
{
    internal abstract class Animal : IAnimal
    {
        public int Age { get; set; }
        public string Gender { get; set; } = null!;

        public abstract void MakeSound();

        public virtual void ShowBirthYear()
        {
            var birthYear = DateTime.Now.Year - Age;
            Console.WriteLine(birthYear);
        }
    }
}
