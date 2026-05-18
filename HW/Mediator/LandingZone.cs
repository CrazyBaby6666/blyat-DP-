namespace DefaultNamespace;

public abstract class LandingZone
{
    protected IMediator _mediator;
    protected bool _isTaken;
    
    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }

    public virtual void Land()
    {
        _isTaken = true;
    }
    
    public virtual void TakeOff()
    {
        _isTaken = false;
    }
}