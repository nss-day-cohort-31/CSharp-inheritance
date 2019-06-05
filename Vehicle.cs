using System;

namespace inheritance
{
  public class Vehicle
  {
    protected string _name;

    public Vehicle(string name) {
      _name = name;
    }
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }
    public virtual void OilChange()
    {
      Console.WriteLine($"Oil change on {_name}");
    }
  }

}
