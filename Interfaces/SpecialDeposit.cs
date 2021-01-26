using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Interfaces
{
    public class SpecialDeposit : Deposit, IProlongable
    {
        public new decimal Amount { get; }
        public new int Period { get; }

        public SpecialDeposit(decimal amount, int period) : base(amount, period)
        {
            Amount = amount;
            Period = period;
        }

        public override decimal Income()
        {
            decimal totalIncome = 0;
            decimal newAmount = Amount;
            for (int i = 0; i <= Period; i++)
            {
                totalIncome += newAmount * ((decimal)i / 100);
                newAmount = newAmount * (1 + (decimal)i / 100);
            }
            return totalIncome;
        }

           public bool CanToProlong()
        {
            if (Amount > 1000) return true;
            else return false;
        }
        

    }

}
