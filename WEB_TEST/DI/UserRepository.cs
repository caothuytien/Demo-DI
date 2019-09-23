using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_TEST.Model;

namespace WEB_TEST.DI
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAll()
        {
            return new List<User>()
        {
            new User()
            {
                FirstName = "Tien",
                LastName = "Cao",
                Username = "tiencao123"
            },
            new User()
            {
                FirstName = "Mai",
                LastName = "Ho",
                Username = "maiha745"
            },
            new User()
            {
                FirstName = "Ngoc",
                LastName = "",
                Username = "ngoc789"
            }
        };
        }
    }
}
