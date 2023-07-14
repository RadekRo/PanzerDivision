namespace PanzerDivision.Model;

public class Tank : Vehicle
{
    public GermanTanks Type;
    public Tank(GermanTanks tankType)
    {
        Type = tankType;

    }

    public override string ToString()
    {
        return $"This is a German ({Id}) tank of a type: {Type.ToString()}";
    }

}
