using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightArena
{
    //Superhero class
    public class Superhero
    {
        //Varibles
        public double Lives { get; set; } = 0;
        public string Name { get; set; } = "Superhero";

        public double Attack { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double AttackMin { get; set; } = 0;

        public double Deffence { get; set; } = 0;
        public double DeffenceMax { get; set; } = 0;
        public double DeffenceMin { get; set; } = 0;

        public double HitPoints { get; set; } = 0;

    }

    //Konfu class : Superhero
    internal class KongFuHarry : Superhero
    {
        //Cunstructor
        public KongFuHarry(string name = "Superhero", double attack = 0, double deffence = 0, double hitPoints = 0)
        {
            Name = name;
            Attack = attack;
            Deffence = deffence;
            HitPoints = hitPoints;
        }

    }

    //dog class : Superhero
    internal class SuperDogDino : Superhero
    {
        //Cunstructor
        public SuperDogDino(string name = "Superhero", double attackMax = 0, double attackMin = 0, double deffenceMax = 0, double deffenceMin = 0, double hitPoints = 0)
        {
            Name = name;
            AttackMax = attackMax;
            AttackMin = attackMin;
            DeffenceMax = deffenceMax;
            DeffenceMin = deffenceMin;
            HitPoints = hitPoints;
        }
    }

    //karl class : Superhero
    internal class KarlTheFast : Superhero
    {
        //Cunstructor
        public KarlTheFast(string name = "Superhero", double attackRight = 0, double attackLeft = 0, double deffence = 0, double hitPoints = 0)
        {
            Name = name;
            AttackMax = attackRight;
            AttackMin = attackLeft;
            Deffence = deffence;
            HitPoints = hitPoints;
        }
    }

    //gunner class : Superhero
    internal class PoisonGunner : Superhero
    {
        //Cunstructor
        public PoisonGunner(string name = "Superhero", double attackMax = 0, double attackMin = 0, double deffence = 0, double hitPoints = 0)
        {
            Name = name;
            AttackMax = attackMax;
            AttackMin = attackMin;
            Deffence = deffence;
            HitPoints = hitPoints;
        }
    }

    //mouse class : Superhero
    internal class TinyMouseMikkel : Superhero
    {
        //Cunstructor
        public TinyMouseMikkel(string name = "Superhero", double attack = 0, double deffence = 0, double hitPoints = 0)
        {
            Name = name;
            Attack = attack;
            Deffence = deffence;
            HitPoints = hitPoints;
        }

    }

    //cat class : Superhero
    internal class CatTiger : Superhero
    {
        //Cunstructor
        public CatTiger(double lives = 0, string name = "Superhero", double attackBig = 0, double attackSmall = 0, double deffence = 0, double hitPoints = 0)
        {
            Lives = lives;
            Name = name;
            AttackMax = attackSmall;
            AttackMin = attackBig;
            Deffence = deffence;
            HitPoints = hitPoints;
        }
    }

    //goat class : Superhero
    internal class RubberGoatIvan : Superhero
    {
        //Cunstructor
        public RubberGoatIvan(string name = "Superhero", double attack = 0, double deffence = 0, double hitPoints = 0)
        {
            Name = name;
            Attack = attack;
            Deffence = deffence;
            HitPoints = hitPoints;
        }

    }

    //moose class : Superhero
    internal class MooseEgon : Superhero
    {
        //Cunstructor
        public MooseEgon(string name = "Superhero", double attackMax = 0, double attackMin = 0, double deffence = 0, double hitPoints = 0)
        {
            Name = name;
            AttackMax = attackMax;
            AttackMin = attackMin;
            Deffence = deffence;
            HitPoints = hitPoints;
        }
    }
}
