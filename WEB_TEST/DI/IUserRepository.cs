using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_TEST.Model;

namespace WEB_TEST.DI
{
    public interface IUserRepository
    {
        List<User> GetAll();
    }
}
