using System.Globalization;

namespace PanzerDivision.Model;

public class Division
{
    private string Name = string.Empty;
    private int Number; 
    private List<Vehicle> Vehicles = new List<Vehicle>();
    private List<Soldier> Soldiers = new List<Soldier>();

    public Division(string name, int number, string type)
    {
        Name = name;
        Number = number;
    }
    public void AddVehicle(Vehicle vehicle)
    {
        vehicle.Id = Vehicles.Count + 1;
        Vehicles.Add(vehicle);
    }
}
