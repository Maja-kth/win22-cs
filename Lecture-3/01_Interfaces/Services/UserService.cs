using _01_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interfaces.Services
{
    internal class UserService : IUserService
    {
        public void AddToList(IUser user)
        {
            throw new NotImplementedException();
        }

        public IUser Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public void RemoveFromList(IUser user)
        {
            throw new NotImplementedException();
        }

        public void NotInInterface()
        {

        }
    }
}
