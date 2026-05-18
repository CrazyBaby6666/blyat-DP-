namespace DefaultNamespace;

public class LandingPad : LandingZone
{
    private Helicopter _currentVehicle;

    public LandingPad(string id)
    {
        _id = id;
    }

    public override Land(Helicopter vehicle)
    {
        base.Land(vehicle);
        _currentVehicle = vehicle;
    }

    public override TakeOff(Helicopter vehicle)
    {
        base.Land(vehicle);
        _currentVehicle = null;
    }
}