using PanzerDivision.Model;

namespace PanzerDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank(GermanTanks.Tiger);
            Console.WriteLine(tank);
        }
    }
}