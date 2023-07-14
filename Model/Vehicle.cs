namespace PanzerDivision.Model;

public abstract class Vehicle
{
    public int Id { get; set; }
    public List<Soldier> Soldiers { get; set; } = new List<Soldier>();
}
