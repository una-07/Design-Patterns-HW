using System;

public class Coffee : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Завариваем кофе");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Добавляем сахар и молоко");
    }

    protected override bool CustomerWantsCondiments()
    {
        Console.WriteLine("Добавить сахар и молоко? (y/n)");

        string answer = Console.ReadLine();

        return answer.ToLower().StartsWith("y");
    }
}
