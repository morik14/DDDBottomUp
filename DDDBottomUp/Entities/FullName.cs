using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DDDBottomUp.ValueObjects;

namespace DDDBottomUp.Entities
{
    public sealed class FullName
    {
        public FullName(UserName firstName, UserName lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public UserName FirstName { get; }
        public UserName LastName { get; }
    }
}
