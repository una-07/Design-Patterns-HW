public class DoorCloseCommand : ICommand
{
    private Door door;

    public DoorCloseCommand(Door door)
    {
        this.door = door;
    }

    public void Execute()
    {
        door.Close();
    }

    public void Undo()
    {
        door.Open();
    }
}
