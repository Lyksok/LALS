namespace Lykso_Aerospace_Launch_System.Rockets;

public interface ILaunchable
{
    protected void PrelaunchUnit();
    protected void LaunchUnit();
    protected void AscentUnit();
    protected void OrbitalUnit();
}