using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    //class for the MoneyService, that controls the money things
    //implment the Money inteface
    internal class MoneyService : IMoneyService
    {
        //Double variable for currenMoney
        private double currentMoney = 0;

        //Method for CalculateTotalPayment
        public double CalculateTotalPayment(double amount) {
            //pluses amount to current amount
            currentMoney += amount;

            //Returns currentMoney
            return currentMoney;
        }
    }
}

