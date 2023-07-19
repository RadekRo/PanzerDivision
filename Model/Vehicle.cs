namespace PanzerDivision.Model;

public abstract class Vehicle
{
    public int Id { get; set; }
    protected List<Soldier> Soldiers { get; set; } = new List<Soldier>();
    protected int FuelLevel = 0;
    protected int FuelConsumption = 0;

    public void AddFuel(int qty)
    {
        this.FuelLevel += qty;
    }

    public int GetFuelLevel()
    {
        return this.FuelLevel;
    }

    public string Move(int km)
    {
        if (this.FuelLevel == 0) 
        {
            return "We cannot make a move Herr General, our Fuel tank is empty.";
        }
        for (int i = 1; i <= km;  i++)
        {
            this.FuelLevel -= this.FuelConsumption;
            if (this.FuelLevel <= 0)
            {
                km -= i;
                break;
            }
        }
        return $"FuelLevel {this.FuelLevel}. Tank has stopped. Moved: {km} km.";
    }

}
