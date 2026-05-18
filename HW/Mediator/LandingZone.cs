namespace DefaultNamespace;

public abstract class LandingZone
{
    protected string _id;
    protected IMediator _mediator;
    protected bool _isTaken;
    
    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }

    public virtual void Land(AirVehicle vehicle)
    {
        vehicle.Land();
        _isTaken = true;
    }
    
    public virtual void TakeOff(AirVehicle vehicle)
    {
        vehicle.TakeOff();
        _isTaken = false;
    }
}