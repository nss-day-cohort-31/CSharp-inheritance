using System;

namespace inheritance
{
  public class Tesla : Vehicle
  {
    public double BatteryKWh { get; set; }

    public Tesla(string name, double battery):base(name) {
      BatteryKWh = battery;
    }

    public Tesla(string name):base(name) {}

    public void ChargeBattery() { 
      Console.WriteLine("Charging...");
     }

     public override void OilChange() {
       Console.WriteLine($"Tesla, {_name}, is getting an oil change.");
     }
  }
}
