namespace _03_Abstractions.Interfaces
{
    internal interface IAnimal
    {
        int Age { get; set; }
        string Gender { get; set; }

        void MakeSound();
        void ShowBirthYear();
    }
}
