using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Interfaces
{
    public class LongDeposit : Deposit, IProlongable
    {
        public new readonly decimal Amount;
        public new readonly int Period;
        public LongDeposit(decimal amount, int period) : base(amount, period)
        {
            Amount = amount;
            Period = period;
        }

        public override decimal Income()
        {
            decimal percent = 15;
            decimal totalIncome = 0;
            decimal newAmount = Amount;
            for (int i = 1; i <= Period; i++)
            {
                if (i >= 7)
                {
                    totalIncome += newAmount * (percent / 100);
                    newAmount = newAmount * (1 + percent / 100);
                }
            }
            return totalIncome;
        }
        public bool CanToProlong()
        {
            if (Period > 3 * 12) return true;
            else return false;
        }
    }

}
