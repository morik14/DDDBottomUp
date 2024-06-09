using DDDBottomUp.Entities;
using DDDBottomUp.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBottomUp.Repositories
{
    public interface IUserRepository
    {
        void Save(User user);
        User Find(UserName userName);
    }
}
