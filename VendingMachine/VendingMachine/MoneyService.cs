using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class MoneyService : IMoneyService
    {
        private double currentMoney = 0;

        public double CalculateTotalPayment(double amount) {
            currentMoney += amount;

            return currentMoney;
        }
    }
}
