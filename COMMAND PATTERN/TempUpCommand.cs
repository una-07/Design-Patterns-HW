public class TempUpCommand : ICommand
{
    private Thermostat thermostat;

    public TempUpCommand(Thermostat thermostat)
    {
        this.thermostat = thermostat;
    }

    public void Execute()
    {
        thermostat.Increase();
    }

    public void Undo()
    {
        thermostat.Decrease();
    }
}
