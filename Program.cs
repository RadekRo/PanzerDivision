using PanzerDivision.Model;

namespace PanzerDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank(GermanTanks.Tiger);
            Console.WriteLine(tank.Type);
            if (tank.Type == GermanTanks.Tiger)
            {
                Console.WriteLine("This is a Tiger tank!");
            }
        }
    }
}