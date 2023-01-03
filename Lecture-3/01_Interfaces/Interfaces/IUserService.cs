namespace _01_Interfaces.Interfaces
{
    internal interface IUserService
    {
        void AddToList(IUser user);
        void RemoveFromList(IUser user);
        IEnumerable<IUser> GetAll();
        IUser Get(int id);  
    }
}
