using System;

public class Thermostat
{
    private int temperature = 20;

    public void Increase()
    {
        temperature++;
        Console.WriteLine($"Температура увеличена до {temperature}");
    }

    public void Decrease()
    {
        temperature--;
        Console.WriteLine($"Температура уменьшена до {temperature}");
    }
}
