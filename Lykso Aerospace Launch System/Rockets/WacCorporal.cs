using Lykso_Aerospace_Launch_System.Prelaunch;
using Lykso_Aerospace_Launch_System.Snippets;

namespace Lykso_Aerospace_Launch_System.Rockets;

public class WacCorporal : Rocket,ILaunchable
{
    public string Name = "WAC Corporal";
    
    public WacCorporal(KrpcConnection conn) : base(conn)
    {
        Console.WriteLine("Connection established with :\n\t"+Name);
    }

    public void PrelaunchUnit()
    {
        new Throttle(ActVessel, 1).Run();
        new Countdown(5).Start();
    }

    public void LaunchUnit()
    {
        new SimpleStage(ActVessel).Run();
    }

    public void AscentUnit()
    {
        
    }

    public void OrbitalUnit()
    {
        
    }

    public void StartProcedure()
    {
        PrelaunchUnit();
        LaunchUnit();
        AscentUnit();
        OrbitalUnit();
        Dispose();
    }
}