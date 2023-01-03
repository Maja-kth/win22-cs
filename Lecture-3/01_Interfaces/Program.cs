
using _01_Interfaces.Interfaces;
using _01_Interfaces.Models;
using _01_Interfaces.Services;

UserService userService = new UserService();
userService.Get(1);
userService.GetAll();
userService.AddToList(new User());
userService.RemoveFromList(new User());
userService.NotInInterface();


IUserService iuserService = new UserService();
iuserService.Get(1);
iuserService.GetAll();
iuserService.AddToList(new User());
iuserService.RemoveFromList(new User());
iuserService.NotInInterface();