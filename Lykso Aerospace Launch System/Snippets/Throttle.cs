using KRPC.Client.Services.SpaceCenter;

namespace Lykso_Aerospace_Launch_System.Snippets;

public class Throttle : ISnippet
{
    private float _throttle;
    private Vessel _vessel;

    public Throttle(Vessel vessel, float newThrottle)
    {
        _vessel = vessel;
        _throttle = newThrottle;
    }

    public void Run()
    {
        _vessel.Control.Throttle = _throttle;
        Console.WriteLine($"Adjusting throttle at {Math.Round(_throttle*100, 0)}%");
    }
}