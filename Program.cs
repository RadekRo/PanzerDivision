using PanzerDivision.Model;

namespace PanzerDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank(GermanTanks.Tiger);
            Tank tank2 = new Tank(GermanTanks.Panther);
            Console.WriteLine(tank);
            Console.WriteLine(tank.Type);
            if (tank.Type == GermanTanks.Tiger)
            {
                Console.WriteLine("This is a Tiger tank!");
            }
            Division myDivision = new("Leibstandarte Adolf Hitler", 2, "Waffen-SS");
            myDivision.AddVehicle(tank);
            myDivision.AddVehicle(tank2);
            myDivision.Meldungen();
        }
    }
}