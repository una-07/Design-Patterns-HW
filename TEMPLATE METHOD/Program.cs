using System;

class Program
{
    static void Main()
    {
        Beverage tea = new Tea();
        Beverage coffee = new Coffee();

        Console.WriteLine("Готовим чай:");
        tea.PrepareRecipe();

        Console.WriteLine("\nГотовим кофе:");
        coffee.PrepareRecipe();
    }
}
