using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample.Models
{
    internal record Money
    {
        public decimal Amount { get; init; }
        public string Currency { get; init; }


        public Money(decimal amount, string currency)
        {
            Amount= amount;
            Currency= currency;
        }
    }
}
