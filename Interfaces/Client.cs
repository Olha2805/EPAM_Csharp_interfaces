using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Interfaces
{
    public class Client : IEnumerable  //<Deposit>
    {
        public new decimal Amount { get; }
        private Deposit[] deposits;
        int depositPosition = -1;
        public Client()
        {
            deposits = new Deposit[10];
        }
        public bool AddDeposit(Deposit deposit)
        {
            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] == null)
                {
                    deposits[i] = deposit;
                    return true;
                }
            }
            return false;        
        }

        public decimal TotalIncome()
        {
            decimal totalIncome = 0;

            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] != null) totalIncome += deposits[i].Income();
            }
            return totalIncome;
        }
        public decimal MaxIncome()
        {
            decimal maxIncome = deposits[0].Income();
            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] != null)
                {
                    if (deposits[i].Income() > maxIncome) maxIncome = deposits[i].Income();
                }
            }
            return maxIncome;
        }
        public decimal GetIncomeByNumber(int number)
        {
            decimal valueOfIncome = 0;
            if (deposits[number - 1] != null) valueOfIncome = deposits[number - 1].Income();
            return valueOfIncome;            
        }


       

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < deposits.Length; i++)
                yield return (deposits[i].Income() + deposits[i].Amount);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void DepositEnumerator (Deposit[] deposits)
        {
            this.deposits = deposits;
        }

        public bool MoveNext()
        {
            if (depositPosition < deposits.Length - 1)
            {
                depositPosition++;
                return true;
            }
            else return false;
        }
        public void SortDeposit(Deposit[] deposits)
        {
            Array.Sort(deposits);
        }
        
    }
}

