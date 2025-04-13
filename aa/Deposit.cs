using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Deposit
    {
        public string FullName { get; set; }
        public double Amount { get; set; }
        public static double InterestRate = 0.05;

        public static Deposit operator ++(Deposit deposit)
        {
            deposit.Amount += deposit.Amount * InterestRate;
            return deposit;
        }

        //получение процентной ставки
        public static double GetInterestRate()
        {
            return InterestRate;
        }
    }

    public class Credit
    {
        public string FullName { get; set; }
        public double Amount { get; set; }
        public static double InterestRate = 0.1;

        public static Credit operator -(Credit credit, double payment)
        {
            credit.Amount -= payment;
            return credit;
        }

        //получение процентной ставки
        public static double GetInterestRate()
        {
            return InterestRate;
        }
    }
}
