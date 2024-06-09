using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBottomUp.ValueObjects
{
    public sealed class UserId : ValueObject<UserId>
    {
        public UserId(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public string DisplayValue => Value;

        protected override bool EqualsCore(UserId other)
        {
            throw new NotImplementedException();
        }
    }
}
