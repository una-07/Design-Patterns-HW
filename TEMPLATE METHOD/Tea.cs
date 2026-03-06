using System;

public class Tea : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Завариваем чай");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Добавляем лимон");
    }
}
