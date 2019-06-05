
using System;

namespace inheritance
{
  public class Zero : Vehicle
  {  // Electric motorcycle
    public double BatteryKWh { get; set; }

    public Zero(string name):base(name) {}

    public void ChargeBattery()
    {
      Console.WriteLine("Charging...");
    }
  }
}
