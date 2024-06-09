using DDDBottomUp.Entities;
using DDDBottomUp.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBottomUp.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        public Dictionary<UserId, User> Store { get; } = new Dictionary<UserId, User>();

        public User Find(UserName userName)
        {
            var target = Store.Values.FirstOrDefault(user => userName.Equals(user.UserName));

            if (target != null)
            {
                return Clone(target);
            }
            else
            {
                return null;
            }
        }

        public void Save(User user)
        {
            Store[user.UserId] = Clone(user);
        }

        private User Clone(User user)
        {
            return new User(user.UserId, user.UserName);
        }
    }
}
