using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBottomUp.Entities
{
    public sealed class Money
    {
        private readonly decimal _amount;
        private readonly string _currency;

        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public decimal Amount { get; private set; }
        public string Currency { get; }

        public Money Add(Money arg)
        {
            if (arg == null) throw new ArgumentNullException(nameof(arg));
            if (Currency != arg.Currency) throw new ArgumentException("通貨単位が異なります");

            return new Money(Amount + arg.Amount, Currency);
        }

        public Money Multiply(decimal rate)
        {
            Amount *= rate;
            return new Money(Amount, Currency);
        }
    }
}
