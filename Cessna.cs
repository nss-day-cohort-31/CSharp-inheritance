using System;

namespace inheritance
{
  public class Cessna
  {  // Propellor light aircraft
    public double FuelCapacity { get; set; }
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public void RefuelTank()
    {
      Console.WriteLine("Refueling...");
    }
  }
}
