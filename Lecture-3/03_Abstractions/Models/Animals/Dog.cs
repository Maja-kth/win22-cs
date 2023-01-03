namespace _03_Abstractions.Models.Animals
{
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Hunden säger woooooowwww!");
        }

        public override void ShowBirthYear()
        {
            Console.Write("Hunden föddes ");
            base.ShowBirthYear();
        }
    }
}
