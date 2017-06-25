using Eticketer.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticketer.Core.Managers
{
    public class UserManager
    {
        private UserRepository _user;

        public UserManager()
        {
            DataContext context = new DataContext();
            _user = new UserRepository(context);
        }
        public UserManager(UserRepository user)
        {
            _user = user;
        }
    }
}
