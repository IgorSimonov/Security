using System.Collections.Generic;
using System.Linq;

namespace Доступы_к_файлам
{
    public class OperationsSystem
    {
        public Store _store;
        public List<User> _users;
        public User CurrentUser;

        public OperationsSystem()
        {
            _store = new Store();
            _users = new List<User>
            {
                new User{Login = "admin", Password = "admin"},
                new User{Login = "User1", Password = "User1"},
                new User{Login = "User2", Password = "User2"},
                new User{Login = "User3", Password = "User3"},
                new User{Login = "User4", Password = "User4"},
                new User{Login = "User5", Password = "User5"},
                new User{Login = "User6", Password = "User6"},
                new User{Login = "User7", Password = "User7"},
                new User{Login = "User8", Password = "User8"},
                new User{Login = "User9", Password = "User9"},
            };
        }
        
        public void Authorize(string login, string pass)
        {
            CurrentUser = _users.FirstOrDefault(x => x.Login == login && x.Password == pass);
        }

        public void LogOut()
        {
            CurrentUser = default;
        }
    }
}