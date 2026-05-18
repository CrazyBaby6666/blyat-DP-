namespace DefaultNamespace;

public class ControlTower : IMediator;
{
    private Queue<Airplane> _airplanesQueue;
    private Queue<Helicopter> _chopperQueue;

    public ControlTower(Helicopter _chopper = null, Airplane _airplane = null)
    {
        _airplanesQueue = new Queue<Airplane>();
        _chopperQueue = new Queue<Helicopter>();

        if (_airplane != null)
        {
            _airplane.SetMediator(this);
            _airplanesQueue.Enqueue(_airplane);
        }
        
        if (_chopper != null)
        {
            _chopper.SetMediator(this);
            _chopperQueue.Enqueue(_chopper);
        }
    }