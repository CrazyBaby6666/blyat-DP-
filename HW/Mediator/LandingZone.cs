namespace DefaultNamespace;

public abstract class LandingZone
{
    private IMediator _mediator;
    
    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }
}