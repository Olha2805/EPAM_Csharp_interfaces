using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Interfaces
{

    public abstract class Deposit : IComparable<Deposit>
    {
        public decimal Amount { get; }
        public int Period { get; }

        public Deposit(decimal Amount, int Period)
        {
            decimal depositAmount = Amount;
            int depositPeriod = Period;
        }
        public abstract decimal Income();
        public int CompareTo(Deposit deposit) 
        {
            return Amount.CompareTo(deposit.Amount);
        }
      
    }

}
