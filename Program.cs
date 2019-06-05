using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla coolCar = new Tesla("Rose", 22.22);
            coolCar.MainColor = "Blue";
            Console.WriteLine(coolCar.MainColor);
            coolCar.OilChange();

            TCart coolCart = new TCart("Gigabyte");
            coolCart.MaximumOccupancy = "55";
            Console.WriteLine(coolCart.MaximumOccupancy);
            coolCart.OilChange();
        }
    }
}
