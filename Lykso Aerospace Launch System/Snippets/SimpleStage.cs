using KRPC.Client.Services.SpaceCenter;

namespace Lykso_Aerospace_Launch_System.Snippets;

public class SimpleStage : ISnippet
{
    private Vessel _vessel;

    public SimpleStage(Vessel vessel)
    {
        _vessel = vessel;
    }

    public void Run()
    {
        _vessel.Control.ActivateNextStage();
        Console.WriteLine("Staging");
    }
}