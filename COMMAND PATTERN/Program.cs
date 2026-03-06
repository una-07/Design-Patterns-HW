using System;

class Program
{
    static void Main()
    {
        Light light = new Light();
        Door door = new Door();
        Thermostat thermostat = new Thermostat();

        Invoker invoker = new Invoker();

        invoker.ExecuteCommand(new LightOnCommand(light));
        invoker.ExecuteCommand(new DoorOpenCommand(door));
        invoker.ExecuteCommand(new TempUpCommand(thermostat));

        Console.WriteLine("Отмена последней команды:");

        invoker.Undo();
    }
}
