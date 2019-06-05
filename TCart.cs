using System;

namespace inheritance {
  public class TCart : Tesla {

    public TCart(string name):base(name, 55.123){}
    public override void OilChange() {
      Console.WriteLine($"TCart named {_name} is getting an oil change");
    }
  }
}
