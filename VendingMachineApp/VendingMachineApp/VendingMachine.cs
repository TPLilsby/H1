using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineApp
{
    public class VendingMachine
    {
        //Incasulate Soda
        public Soda Soda { get; set; }

        //Incasulate Candy
        public Candy Candy { get; set; }

        //Make the list to the soda's
        public List<Soda> SodaList = new List<Soda>();

        //Make the list to the candy
        public List<Candy> CandyList = new List<Candy>();

        //Vending machine cunstructor
        public VendingMachine()
        {
            #region SODA
            //Id count for soda
            byte countSodaId = 1;

            //Add ten soda's to the vending machine
            for (int i = 0; i < 10; i++)
            {
                SodaList.Add(Soda = new Soda(countSodaId, 0.5, 22));
                countSodaId++;
            }
            #endregion

            #region CANDY
            //Id count for candy
            byte countCandyId = 1;

            for (var i = 0; i < 15; i++)
            {
                CandyList.Add(Candy = new Candy(countCandyId, 75, 17));
                countCandyId++;
            }
            #endregion
        }


    }
}


