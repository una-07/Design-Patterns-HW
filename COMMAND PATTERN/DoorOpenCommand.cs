public class DoorOpenCommand : ICommand
{
    private Door door;

    public DoorOpenCommand(Door door)
    {
        this.door = door;
    }

    public void Execute()
    {
        door.Open();
    }

    public void Undo()
    {
        door.Close();
    }
}
