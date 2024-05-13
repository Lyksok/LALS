using KRPC.Client.Services.SpaceCenter;
using Lykso_Aerospace_Launch_System.Snippets;

namespace Lykso_Aerospace_Launch_System.Launch;

public class SingleStepLaunch : ISnippet
{
    private Vessel _actVessel;
    private int _throttle;
    
    public SingleStepLaunch(Vessel actVessel, int throttle = 1)
    {
        _actVessel = actVessel;
        _throttle = throttle;
    }

    public void Run()
    {
        new Throttle(_actVessel, _throttle).Run();
        new SimpleStage(_actVessel).Run();
    }
}