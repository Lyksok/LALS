using Lykso_Aerospace_Launch_System.Prelaunch;

namespace Lykso_Aerospace_Launch_System.Rockets;

public class WacCorporalBoosted : Rocket,ILaunchable
{
    public string Name = "WAC Corporal Boosted";

    public WacCorporalBoosted(KrpcConnection conn) : base(conn)
    {
        Console.WriteLine("Connection established with :\n\t"+Name);
    }

    public void PrelaunchUnit()
    {
        ActVessel.Control.Throttle = 1;
        new Countdown(5).Start();
    }

    public void LaunchUnit()
    {
        ActVessel.Control.ActivateNextStage();
    }

    public void AscentUnit()
    {
        // Not used
    }

    public void OrbitalUnit()
    {
        Dispose();
    }
}