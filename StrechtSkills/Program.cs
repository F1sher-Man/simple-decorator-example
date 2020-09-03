using System;

namespace StrechtSkills
{
    class Program
    {
        static void Main(string[] args)
        {
            FiatCar Panda = new FiatCar();
            Console.WriteLine(Panda.GetName());
            Console.WriteLine("----------------------");
            WifiDecorator PandaWithWifi = new WifiDecorator(Panda);
            Console.WriteLine(PandaWithWifi.GetName());
            Console.WriteLine("----------------------");

            GPSDecorator PandaWithWifiAndGPS = new GPSDecorator(PandaWithWifi);
            Console.WriteLine(PandaWithWifiAndGPS.GetName());
            Console.WriteLine("----------------------");

            GPSDecorator E36FullyEquiped = new GPSDecorator(new WifiDecorator(new RadioDecorator(new BMWCar())));
            Console.WriteLine(E36FullyEquiped.GetName());
            Console.WriteLine(E36FullyEquiped.GetPrice());
            Console.WriteLine("----------------------");
            Console.ReadKey();
        }
    }
}
