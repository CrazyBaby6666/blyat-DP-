namespace DefaultNamespace;

public class Runway : LandingZone
{
    private Airplane _currentVehicle;
    
    public Runway(string id)
    {
        _id = id;
    }
    
    public override Land(Airplane vehicle)
    {
        base.Land(vehicle);
        _currentVehicle = vehicle;
    }

    public override TakeOff(Airplane vehicle)
    {
        base.Land(vehicle);
        _currentVehicle = null;
    }
}