namespace DefaultNamespace;

public class Runway : LandingZone
{
    private Airplane _currentVehicle;
    private float _length;
    
    public Runway(string id, float length)
    {
        _id = id;
        _length = length;
    }
    
    public override Land(Airplane vehicle)
    {
        base.Land(vehicle);
    }

    public override TakeOff(Airplane vehicle)
    {
        base.Land(vehicle);
        _currentVehicle = null;
    }
}