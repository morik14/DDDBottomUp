using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DDDBottomUp.ValueObjects
{
    public sealed class UserName : ValueObject<UserName>
    {
        public UserName(string value)
        {
            if (value == null) throw new ArgumentNullException("value");
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$")) 
                throw new ArgumentException("許可されていない文字がつかわれています。", nameof(value));

            Value = value;
        }

        public string Value { get; }

        public string DisplayValue => Value;

        protected override bool EqualsCore(UserName other)
        {
            return this.Value == other.Value;
        }
    }
}
