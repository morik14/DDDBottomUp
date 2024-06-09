using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBottomUp.ValueObjects
{
    public abstract class ValueObject<T> where T : ValueObject<T>
    {
        public override bool Equals(object obj)
        {
            var vo = obj as T;
            if (vo == null)
            {
                return false; 
            }

            return EqualsCore(vo);
        }

        public static bool operator ==(ValueObject<T> vol,
            ValueObject<T> vo2)
        {
            return Equals(vol, vo2);
        }

        public static bool operator !=(ValueObject<T> vol,
            ValueObject<T> vo2)
        {
            return !Equals(vol, vo2);
        }

        protected abstract bool EqualsCore(T other);

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
