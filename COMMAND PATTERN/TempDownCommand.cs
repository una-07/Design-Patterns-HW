public class TempDownCommand : ICommand
{
    private Thermostat thermostat;

    public TempDownCommand(Thermostat thermostat)
    {
        this.thermostat = thermostat;
    }

    public void Execute()
    {
        thermostat.Decrease();
    }

    public void Undo()
    {
        thermostat.Increase();
    }
}
