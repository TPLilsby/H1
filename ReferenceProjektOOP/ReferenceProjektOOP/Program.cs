
using System.Drawing;
using System.Runtime.Intrinsics.Arm;

//Jo mere vi nedarver i hirakiet, jo mere specaliseret bliver

class Animal
{
    protected bool Heart { get; set; }

    public virtual bool fetchHeart() { return Heart; }
}

 class Dog : Animal
{
    protected bool Fur { get; set;}
    public string Eyes { get; set;}
}

sealed class Lab : Dog
{
    public string Color { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        Animal animalDog = new Dog();
        Animal animalLab = new Lab();

        ((Lab)animalLab).Color = "Black";
        ((Dog)animalLab).Eyes = "Black";
    }
}