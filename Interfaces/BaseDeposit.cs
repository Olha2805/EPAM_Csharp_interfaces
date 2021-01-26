using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Interfaces
{

    public class BaseDeposit : Deposit
    {
        public new decimal Amount { get; }
        public new int Period { get; }
        public BaseDeposit(decimal amount, int period) : base(amount, period)
        {
            Amount = amount;
            Period = period;
        }

        public override decimal Income()
        {
            decimal percent = 5;
            decimal totalIncome = 0;
            decimal newAmount = Amount;
            for (int i = 1; i <= Period; i++)
            {
                totalIncome += newAmount * (percent / 100);
                newAmount = newAmount * (1 + percent / 100);
            }

            return totalIncome;

        }

    }

}
