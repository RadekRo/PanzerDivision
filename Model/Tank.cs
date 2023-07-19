namespace PanzerDivision.Model;

public class Tank : Vehicle
{
    public GermanTanks Type;
    public Tank(GermanTanks tankType)
    {
        Type = tankType;
        FuelLevel = 10;
        FuelConsumption = 10;
    }

    public override string ToString()
    {
        return $"This is a German ({Id}) tank of a type: {Type.ToString()}";
    }

}
