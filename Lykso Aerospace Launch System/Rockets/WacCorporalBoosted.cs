using KRPC.Client;

namespace Lykso_Aerospace_Launch_System.Rockets;

public class WacCorporalBoosted : Rocket,ILaunchable
{
    public string Name = "WAC Corporal Boosted";

    public WacCorporalBoosted(KrpcConnection conn) : base(conn)
    {
        Console.WriteLine("Connection established with :\n\t"+Name);
        
    }

    private void LaunchUnit()
    {
        
    }
}