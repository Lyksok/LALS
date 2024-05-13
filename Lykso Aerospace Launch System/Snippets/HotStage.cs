using KRPC.Client.Services.SpaceCenter;

namespace Lykso_Aerospace_Launch_System.Snippets;

public class HotStage : ISnippet
{
    private SimpleStage _simpleStage;

    public HotStage(Vessel vessel)
    {
        _simpleStage = new SimpleStage(vessel);
    }

    public void Run()
    {
        _simpleStage.Run();
        Thread.Sleep(300);
        _simpleStage.Run();
    }
}