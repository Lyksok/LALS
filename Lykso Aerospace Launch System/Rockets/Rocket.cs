using KRPC.Client;
using KRPC.Client.Services.SpaceCenter;

namespace Lykso_Aerospace_Launch_System.Rockets;

public class Rocket
{
    private KrpcConnection _conn;
    protected Vessel ActVessel;

    protected Rocket(KrpcConnection conn)
    {
        _conn = conn;
        ActVessel = _conn.SpaceCenter().ActiveVessel;
    }

    public void Dispose()
    {
        _conn.Dispose();
        Console.WriteLine("KRPC connection closed ...\nLaunch system shutdown.");
    }
}