using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    //Interface named IMOneyServicefor all the money things
    public interface IMoneyService
    {
        //Method named CalculateTotalPayment for calculating the total payement or insert from user
        double CalculateTotalPayment(double amount);
    }
}
