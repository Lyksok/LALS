using Lykso_Aerospace_Launch_System.Rockets;

namespace Lykso_Aerospace_Launch_System.Launch;

public class SingleStepLaunch
{
    private Rocket _actVessel;
    
    public SingleStepLaunch(Rocket actVessel)
    {
        _actVessel = actVessel;
    }
}