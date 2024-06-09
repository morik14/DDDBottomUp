using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DDDBottomUp.ValueObjects;

namespace DDDBottomUp.Entities
{
    public sealed class User
    {
        public User(UserId userId,UserName userName)
        {
            if (userName == null) throw new ArgumentNullException(nameof(userName));
            UserName = userName;
            UserId = userId;
            //UserId = new UserId(Guid.NewGuid().ToString());
        }

        public UserId UserId { get; }
        public UserName UserName { get; private set; }

        public void ChangeUserName(UserName userName)
        {
            if (userName == null) throw new ArgumentNullException(nameof(userName));
            UserName = userName;
        }
    }
}
