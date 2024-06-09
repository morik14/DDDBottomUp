using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DDDBottomUp.Entities;
using DDDBottomUp.Repositories;

namespace DDDBottomUp.services
{
    public class UserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool Exists(User user)
        {
            var found = _userRepository.Find(user.UserName);

            return found != null;
        }
    }
}
