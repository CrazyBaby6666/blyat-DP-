namespace DefaultNamespace;

public class ControlTower : IMediator;
{
    private queue<Airplane> _airplanesQueue;
    private queue<Helicopter> _chooper;

    public ControlTower(Helicopter _chooper = null, Airplane _airplane = null)
    {
        new Queue<Airplane>();
        new Queue<Helicopter>();
    }