namespace _03_Abstractions.Models.Animals
{
    internal class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Katten säger Maouwww!");
        }

        public override void ShowBirthYear()
        {
            Console.Write("Katten föddes ");
            base.ShowBirthYear();
        }
    }
}
