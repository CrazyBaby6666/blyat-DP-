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

    public void Notify(AirVehicle sender, string message)
    {
        if (message == "TakeOff")
        {
            Console.WriteLine("Control Tower: " + sender.GetType().Name + " is taking off.");
        }
        if(message == "Land")
        {
            Console.WriteLine("Control Tower: " + sender.GetType().Name + " is landing.");
        }
    }
