using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    //Class named FightingArena
    public class FightingArena
    {
        //Method named StartGame
        public void StartGame()
        {
            //List for superheros
            List<Superhero> superheroList = new List<Superhero>();

            //Making the diffrent superheros
            Superhero kongfu = new KongFuHarry("Kong Fu Harry", 2, 5, 120);
            Superhero dog = new SuperDogDino("Super Dog Dino", 8, 6, 8, 2, 70);
            Superhero fastKarl = new KarlTheFast("Karl the fast", 5, 2, 3, 90);
            Superhero poisonGunner = new PoisonGunner("Poison Gunner", 13, 1, 5, 90);
            Superhero tinymouse = new TinyMouseMikkel("Tiny Mouse Mikkel", 9, 9, 40);
            Superhero cat = new CatTiger(9, "The cat Tiger", 6, 3, 4, 35);
            Superhero goat = new RubberGoatIvan("Rubbed  Goat Ivan", 6, 8, 70);
            Superhero moose = new MooseEgon("The Moose Ivan", 11, 5, 4, 90);

            //Adding superheros to superheroList
            superheroList.Add(kongfu);
            superheroList.Add(dog);
            superheroList.Add(fastKarl);
            superheroList.Add(poisonGunner);
            superheroList.Add(tinymouse);
            superheroList.Add(cat);
            superheroList.Add(goat);
            superheroList.Add(moose);

            //  Writline for start game info
            Console.WriteLine("The start");

            //List for compeeters
            List<Superhero> choosedCompeter = new List<Superhero>();

            int count = 0;
            while (count < 2)
            {
                //Choose  rnd number
                Random rand = new Random();
                int rnd = rand.Next(1, superheroList.Count());

                //Switch for choose compeeters
                switch (rnd)
                {
                    case 1:
                        choosedCompeter.Add(kongfu); count++; superheroList.Remove(kongfu); break;

                    case 2:
                        choosedCompeter.Add(dog); count++; superheroList.Remove(dog); break;

                    case 3:
                        choosedCompeter.Add(fastKarl); count++; superheroList.Remove(fastKarl); break;

                    case 4:
                        choosedCompeter.Add(poisonGunner); count++; superheroList.Remove(poisonGunner);
                        break;

                    case 5:
                        choosedCompeter.Add(tinymouse); count++; superheroList.Remove(tinymouse);
                        break;

                    case 6:
                        choosedCompeter.Add(cat); count++; superheroList.Remove(cat);
                        break;

                    case 7:
                        choosedCompeter.Add(goat); count++; superheroList.Remove(goat);
                        break;

                    case 8:
                        choosedCompeter.Add(moose); count++; superheroList.Remove(moose);
                        break;
                }
            }

            //Superhero 1
            Superhero s1 = new Superhero();

            //Superhero 2
            Superhero s2 = new Superhero();

            //s1
            s1 = choosedCompeter[0];

            //s2
            s2 = choosedCompeter[1];

            // s1 vs s2
            Console.WriteLine($"First Round {s1.Name} vs  {s2.Name}");

            //s1 rnd attack
            Random rnd = new Random();

            //s1 attack
            int s1punch = rnd.Next( (int)s1.AttackMin, (int)s1.AttackMax);

            int s1deffence = (int)s1.Deffence;

            int s2punch = rnd.Next((int)s2.AttackMin, (int)s2.AttackMax);

            int s2deffence = rnd.Next((int)s2.DeffenceMax, (int)s2.DeffenceMin);

        }


        
        //Method for quarter finals
        public void QuarteFinals(List<Superhero> superheroList)
        {
            //List fro compeeters
            List<Superhero> competers = new List<Superhero>();

            //List for winners
            List<Superhero> winners = new List<Superhero>();

            //Add superhero to compete list
            foreach (Superhero competer in superheroList)
            {
                competers.Add(competer);
            }

            FirstRound(competers);
        }

        public void FirstRound(List<Superhero> compeeter)
        {
            List<Superhero> roundCompeeters = new List<Superhero>();

            foreach (Superhero roundCompeeter in compeeter)
            {
                roundCompeeters.Add(roundCompeeter);
            }

            Console.WriteLine();

        }
    }
}
