using System.Globalization;

namespace PanzerDivision.Model;

public class Division
{
    private string Name = string.Empty;
    private int Number;
    private string Type = string.Empty;
    private List<Vehicle> Vehicles = new List<Vehicle>();
    private List<Soldier> Soldiers = new List<Soldier>();

    public Division(string name, int number, string type)
    {
        Name = name;
        Number = number;
        Type = type;
    }
    public void AddVehicle(Vehicle vehicle)
    {
        vehicle.Id = Vehicles.Count + 1;
        Vehicles.Add(vehicle);
    }

    public void Meldungen()
    {
        Console.WriteLine($"This is a {Name} | {Number} {Type} Division:");
        foreach (var vehicle in Vehicles)
        {
            Console.WriteLine(vehicle);
        }
    }
}
