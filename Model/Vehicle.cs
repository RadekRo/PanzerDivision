namespace PanzerDivision.Model;

public abstract class Vehicle
{
    private int Id { get; set; }
    private string Name { get; set; } = string.Empty;
    public List<Soldier> Soldiers { get; set; } = new List<Soldier>();
}
