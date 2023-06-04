
using System.Runtime.Intrinsics.Arm;

abstract class Engine
{
    public abstract double calculateHP();
}

class ElectricEngine : Engine
{
    public virtual double LoadingCapacity() { return 200; }
}

abstract class CompostionEngine : Engine
{
    public double MaxNPM() { return 700; }
    public double CalculateCarbonOxide(double engineSize) { return engineSize * 0.0078; }

}

sealed class BigElectricEngine : ElectricEngine
{
    public override double calculateHP() { return 1020; }
    public override double LoadingCapacity() { return 400; }

}

sealed class MediumElectricEngine : ElectricEngine {
    public override double calculateHP() { return 655; }
    public override double LoadingCapacity() { return 345; }
}

class SmallElectricEngine : ElectricEngine {
    public override double calculateHP() { return 248; }
}

abstract class GasolineEngine : CompostionEngine
{
    public override double MaxNPM() { return 998; }
    public override double CalculatCarbonOxide(double engineSize) { return engineSize * 0.098; }
}

abstract class DieselEngine : CompostionEngine
{
    public override double MaxNPM() { return 1303; }
    public override double CalculatCarbonOxide(double engineSize) { return engineSize * 2.098; }
}

sealed class Engine1000CCM : GasolineEngine
{
    public override double MaxNPM() { return 598; }
}

//Interfaces
interface IEngine
{
    double caculateHP();
}

interface IElectricEngine : IEngine
{
    double LoadinCapacity();
}

interface ICompostionEngine : IEngine
{
    double MaxNPM();
}