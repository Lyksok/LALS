
namespace Lykso_Aerospace_Launch_System.Prelaunch;

public class Countdown
{
    private ushort _countdown;

    public Countdown(ushort seconds)
    {
        _countdown = seconds;
    }

    public void Start()
    {
        Console.WriteLine($"Initiating {_countdown} second{(_countdown>1 ? "s" : "")} countdown ...");
        Thread.Sleep(2000);
        while (_countdown>0)
        {
            Console.WriteLine($"{_countdown}...");
            Thread.Sleep(1000);
            _countdown -= 1;
        }
        Console.WriteLine($"0... Launch !");
    }
}