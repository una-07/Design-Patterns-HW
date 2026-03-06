using System.Collections.Generic;

public class Invoker
{
    private Stack<ICommand> history = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        history.Push(command);
    }

    public void Undo()
    {
        if (history.Count > 0)
        {
            ICommand command = history.Pop();
            command.Undo();
        }
        else
        {
            System.Console.WriteLine("Нет команд для отмены");
        }
    }
}
